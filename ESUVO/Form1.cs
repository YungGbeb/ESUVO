using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Net.Http;
using Html = HtmlAgilityPack;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ESUVO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public static Excel.Application exApp = new Excel.Application();
        public static Excel.Workbook workbook = exApp.Workbooks.Open(@"C:\Users\Глеб\source\repos\ESUVO\ESUVO\bin\Debug\spravka_api.xlsx");
        public static Excel.Worksheet ws = workbook.Worksheets[1];
        public static string ESUVOAddress = @"http://esuvo.platonus.kz/esuvoapigg/";
        public static string RIIid = "39";
        public static string RIIpass = "gnMVFCiXhV";
        private void Form1_Load(object sender, EventArgs e)
        {
            ESUVOTablesListBox.Items.Clear();
            try
            {
                for (int i = 2; i < ws.Rows.Count - 1; i++)
                {
                    string currentCellValue = ws.Cells[i, 1].Value.ToString();
                    string currentCellDefinition = ws.Cells[i, 2].Value.ToString();
                    ESUVOTablesListBox.Items.Add(currentCellDefinition + "(" + currentCellValue + ")");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        
        private void ESUVOTablesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ESUVOMethodsListBox.Items.Clear();
            try
            {
                int currRow = ESUVOTablesListBox.SelectedIndex + 2;
                for (int i = 3; i < ws.Columns.Count; i++)
                {
                    string currMethodCEll = ws.Cells[currRow, i].Value.ToString();
                    ESUVOMethodsListBox.Items.Add(currMethodCEll);

                }
            }
            catch (Exception)
            {
                
            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exApp != null)
            {
                exApp.Quit();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ESUVOMethodsListBox.SelectedItem.ToString().Contains("del"))
            {
                DialogResult dr = MessageBox.Show("Вы действительно хотите удалить выбранные строки?", "Удаление", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    ConvertToJson();
                    PostRequest();
                    ConvertJsonToTable();
                }

            }
            else
            {
                ConvertToJson();
                PostRequest();
                ConvertJsonToTable();
            }

        }

        private void fullnessCheck()
        {
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int cnt = 0;
                foreach (DataGridViewCell item in dataGridView1.Rows[i].Cells)
                {
                    if (item.Value != null)
                    {
                        cnt++;
                    }
                }
                if (cnt == 0)
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }
        private void HTMLTableParse()
        {
            var doc = new HtmlAgilityPack.HtmlDocument();
            using (var client = new WebClient { Encoding = Encoding.UTF8 })
            {
                string html = client.DownloadString(ESUVOAddress + ESUVOMethodsListBox.SelectedItem.ToString());
                doc.LoadHtml(html);
            }
            var table = new DataTable("MY_ble");
            var nodes = doc.DocumentNode.SelectNodes("//table/tr");
            /*
            nodes[0]
            .Elements("th")
            .Select(th => th.InnerText.Trim())
            .ToList()
            .ForEach(header => table.Columns.Add(header));*/
            nodes
            .Skip(1)
            .Select(tr => tr.Elements("td").Select(td => td.InnerText.Trim()).ToArray())
            .ToList()
            .ForEach(row => table.Columns.Add(row[0]));
            dataGridView1.DataSource = table;
        }
        private void ESUVOMethodsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HTMLTableParse();
            
        }

        private void ConvertToJson()
        {

            string JsonQuery = "{\"id_university\":\"" + RIIid + "\",\"password\":\"" + RIIpass + "\",\"values\": [";
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                JsonQuery += "{";
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    JsonQuery += "\"" + dataGridView1.Columns[j].HeaderText.Trim() + "\":\"" + dataGridView1[j,i].Value.ToString().Trim() + "\",";
                }
                JsonQuery = JsonQuery.Substring(0, JsonQuery.Length - 1);
                Console.WriteLine(JsonQuery);
                JsonQuery += "},";

            }
            JsonQuery = JsonQuery.Substring(0, JsonQuery.Length - 1);
            JsonQuery += "]}";
            Console.WriteLine(JsonQuery);
            JsonQueryTextBox.Text = JsonQuery;
        }
        private void PostRequest()
        {
            try
            {
                var httpRequest = (HttpWebRequest)WebRequest.Create(ESUVOAddress + ESUVOMethodsListBox.SelectedItem.ToString());
                httpRequest.Method = "POST";
                httpRequest.ContentType = "application/json";
                using (var requestStream = httpRequest.GetRequestStream())
                using (var writer = new StreamWriter(requestStream))
                {
                    writer.Write(JsonQueryTextBox.Text);
                }
                using (var httpResponse = httpRequest.GetResponse())
                using (var responseStream = httpResponse.GetResponseStream())
                using (var reader = new StreamReader(responseStream))
                {
                    string response = reader.ReadToEnd();
                    JsonQueryTextBox.Text = response;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);   
            }
           
        }

        private void ConvertJsonToTable()
        {
            string JsonString = JsonQueryTextBox.Text;
            JsonString = JsonString.Split('[')[1];
            JsonString = JsonString.Split(']')[0];
            JsonString = "[" + JsonString + "]";
            Console.WriteLine(JsonString);
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(JsonString, typeof(DataTable));
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = int.Parse(fromNumUD.Value.ToString());
            foreach (DataGridViewCell selectedCell in dataGridView1.SelectedCells)
            {
                if (counter < int.Parse(toNumUD.Value.ToString()))
                {
                    selectedCell.Value = counter;
                    counter++;
                } 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int difference = int.Parse(toNumUD.Value.ToString()) - int.Parse(fromNumUD.Value.ToString());
            for (int i = 0; i < difference; i++)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void fromNumUD_ValueChanged(object sender, EventArgs e)
        {
            toNumUD.Minimum = fromNumUD.Value + 1;

        }

        private void toNumUD_ValueChanged(object sender, EventArgs e)
        {
            fromNumUD.Maximum = toNumUD.Value - 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Worksheets.Add();
            worksheet = workbook.Worksheets[1];
            DataTable dataTable = new DataTable();
            application.Visible = true;
            //MessageBox.Show("Выполняется экспорт", "Loading");
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText.ToString();
            }

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j,i] != null)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView1[j, i].Value.ToString();
                    }
                    
                }
            }
            //MessageBox.Show("Loading complete");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var proc = Process.GetProcessesByName("excel");
            foreach (var item in proc)
            {
                item.Kill();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                cell.Value = textBox1.Text;
            }
        }

        private void ExcelImport()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Excel document(*.xls;*.xlsx)|*.xls;*.xlsx";
            ofd.Title = "Выберите документ для загрузки данных";
        
            string fileName = ofd.ShowDialog().ToString();
            Excel.Application importApp = new Excel.Application();
            importApp.Workbooks.Open(fileName);
            Excel.Worksheet worksheet = importApp.Worksheets[1];
            int columncnt = 0;
            foreach (var item in worksheet.Columns.Cells)
            {
                if (item != null)
                {
                    columncnt++;
                } 
                else
                {
                    break;
                }
            }
            for (int i = 0; i < columncnt-1; i++)
            {
                dataGridView1.Columns.Add(worksheet.Cells[1, i + 1].Value.ToString());
            }
            int stopcounter = 0;
            for (int i = 0; i < worksheet.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < columncnt; j++)
                {
                    if (worksheet.Cells[i + 2, j + 1].Value != null)
                    dataGridView1[j, i].Value = worksheet.Rows[i+2, j+1].ToString();  
                    else
                    {
                        stopcounter++;
                        if (stopcounter >3)
                        {
                            break;
                        }
                    }
                }
            }
            importApp.Quit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ConvertToJson();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PostRequest();
        }

        private void button9_Click(object sender, EventArgs e)
        {
                        
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            ExcelImport();
        }

       
    }
}
