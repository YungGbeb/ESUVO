namespace ESUVO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button2;
            this.button1 = new System.Windows.Forms.Button();
            this.ESUVOTablesListBox = new System.Windows.Forms.ListBox();
            this.ESUVOMethodsListBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toNumUD = new System.Windows.Forms.NumericUpDown();
            this.fromNumUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.JsonQueryTextBox = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toNumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(6, 52);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(107, 23);
            button2.TabIndex = 0;
            button2.Text = "Заполнить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1028, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ESUVOTablesListBox
            // 
            this.ESUVOTablesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ESUVOTablesListBox.FormattingEnabled = true;
            this.ESUVOTablesListBox.Location = new System.Drawing.Point(13, 13);
            this.ESUVOTablesListBox.Name = "ESUVOTablesListBox";
            this.ESUVOTablesListBox.Size = new System.Drawing.Size(1009, 108);
            this.ESUVOTablesListBox.TabIndex = 1;
            this.ESUVOTablesListBox.SelectedIndexChanged += new System.EventHandler(this.ESUVOTablesListBox_SelectedIndexChanged);
            // 
            // ESUVOMethodsListBox
            // 
            this.ESUVOMethodsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ESUVOMethodsListBox.FormattingEnabled = true;
            this.ESUVOMethodsListBox.Location = new System.Drawing.Point(1028, 13);
            this.ESUVOMethodsListBox.Name = "ESUVOMethodsListBox";
            this.ESUVOMethodsListBox.Size = new System.Drawing.Size(120, 69);
            this.ESUVOMethodsListBox.TabIndex = 2;
            this.ESUVOMethodsListBox.SelectedIndexChanged += new System.EventHandler(this.ESUVOMethodsListBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 429);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.toNumUD);
            this.panel1.Controls.Add(this.fromNumUD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(button2);
            this.panel1.Location = new System.Drawing.Point(1028, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 537);
            this.panel1.TabIndex = 5;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 223);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Импорт";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 464);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 38);
            this.button8.TabIndex = 11;
            this.button8.Text = "Отправить в JSON";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 424);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 34);
            this.button7.TabIndex = 10;
            this.button7.Text = "Конвертировать в JSON";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 194);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Заполнить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 21);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Экспорт в Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить строки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toNumUD
            // 
            this.toNumUD.Location = new System.Drawing.Point(71, 26);
            this.toNumUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.toNumUD.Name = "toNumUD";
            this.toNumUD.Size = new System.Drawing.Size(42, 20);
            this.toNumUD.TabIndex = 4;
            this.toNumUD.ValueChanged += new System.EventHandler(this.toNumUD_ValueChanged);
            // 
            // fromNumUD
            // 
            this.fromNumUD.Location = new System.Drawing.Point(6, 26);
            this.fromNumUD.Name = "fromNumUD";
            this.fromNumUD.Size = new System.Drawing.Size(42, 20);
            this.fromNumUD.TabIndex = 3;
            this.fromNumUD.ValueChanged += new System.EventHandler(this.fromNumUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "До:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "От:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(959, 668);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "НАО РИИ 2022 Юнг Глеб СУНРиМО";
            // 
            // JsonQueryTextBox
            // 
            this.JsonQueryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JsonQueryTextBox.Location = new System.Drawing.Point(12, 563);
            this.JsonQueryTextBox.Multiline = true;
            this.JsonQueryTextBox.Name = "JsonQueryTextBox";
            this.JsonQueryTextBox.Size = new System.Drawing.Size(1010, 102);
            this.JsonQueryTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 687);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.JsonQueryTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ESUVOMethodsListBox);
            this.Controls.Add(this.ESUVOTablesListBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ЕСУВО";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toNumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ESUVOTablesListBox;
        private System.Windows.Forms.ListBox ESUVOMethodsListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown toNumUD;
        private System.Windows.Forms.NumericUpDown fromNumUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox JsonQueryTextBox;
        private System.Windows.Forms.Button button9;
    }
}

