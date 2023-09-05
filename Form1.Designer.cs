namespace LibraryApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            button4 = new Button();
            comboBox3 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            bookBindingSource = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            comboBox4 = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.ForeColor = SystemColors.WindowText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(31, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(312, 109);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.AccessibleName = "";
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(212, 50);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 0;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1390, 438);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.AccessibleName = "";
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(comboBox3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1382, 410);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Üyelik Oluştur-Sil";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(577, 42);
            label6.Name = "label6";
            label6.Size = new Size(161, 15);
            label6.TabIndex = 9;
            label6.Text = "Silmek İstediğiniz Üyeyi Seçin";
            // 
            // button4
            // 
            button4.Location = new Point(778, 98);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(577, 60);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(276, 23);
            comboBox3.TabIndex = 7;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 159);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefon No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 98);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 5;
            label2.Text = "Adres";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "İsim Soyisim";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(62, 229);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Giriş";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(62, 177);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(269, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1382, 410);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Kitap Kirala";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 84);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 4;
            label5.Text = "Üye Seçiniz";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 23);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Kitap Seçiniz";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(19, 152);
            button2.Name = "button2";
            button2.Size = new Size(265, 40);
            button2.TabIndex = 2;
            button2.Text = "Rent";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(19, 102);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(742, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(742, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listBox1);
            tabPage3.Controls.Add(button1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1382, 410);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Kiralanan Kitaplar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(comboBox4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1382, 410);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Kitap İade Et";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Book);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(42, 55);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(237, 23);
            comboBox4.TabIndex = 0;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 468);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private BindingSource bookBindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ContextMenuStrip contextMenuStrip2;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private ComboBox comboBox3;
        private Button button4;
        private Label label6;
        private ComboBox comboBox4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}