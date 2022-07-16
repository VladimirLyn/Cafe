namespace Cafe
{
    partial class ItemsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.ItemNameTb = new System.Windows.Forms.TextBox();
            this.ItemNumTb = new System.Windows.Forms.TextBox();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(142)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PriceTb);
            this.panel1.Controls.Add(this.ItemNameTb);
            this.panel1.Controls.Add(this.ItemNumTb);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Location = new System.Drawing.Point(128, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 787);
            this.panel1.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(39)))));
            this.button5.Location = new System.Drawing.Point(325, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 75);
            this.button5.TabIndex = 22;
            this.button5.Text = "Удалить (по НОМЕРУ)";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(142)))));
            this.label8.Font = new System.Drawing.Font("Balthazar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.label8.Location = new System.Drawing.Point(22, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 28);
            this.label8.TabIndex = 21;
            this.label8.Text = "Категория товара";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(39)))));
            this.button2.Location = new System.Drawing.Point(169, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 75);
            this.button2.TabIndex = 19;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(142)))));
            this.label7.Font = new System.Drawing.Font("Balthazar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.label7.Location = new System.Drawing.Point(605, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Список товаров";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(142)))));
            this.label4.Font = new System.Drawing.Font("Balthazar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.label4.Location = new System.Drawing.Point(22, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Цена товара";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(142)))));
            this.label3.Font = new System.Drawing.Font("Balthazar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Название товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(142)))));
            this.label1.Font = new System.Drawing.Font("Balthazar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(22, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер товара";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(39)))));
            this.button1.Location = new System.Drawing.Point(8, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 75);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PriceTb
            // 
            this.PriceTb.BackColor = System.Drawing.Color.Blue;
            this.PriceTb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(39)))));
            this.PriceTb.Location = new System.Drawing.Point(242, 216);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(222, 32);
            this.PriceTb.TabIndex = 4;
            // 
            // ItemNameTb
            // 
            this.ItemNameTb.BackColor = System.Drawing.Color.Blue;
            this.ItemNameTb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(39)))));
            this.ItemNameTb.Location = new System.Drawing.Point(242, 124);
            this.ItemNameTb.Name = "ItemNameTb";
            this.ItemNameTb.Size = new System.Drawing.Size(222, 32);
            this.ItemNameTb.TabIndex = 3;
            this.ItemNameTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ItemNumTb
            // 
            this.ItemNumTb.BackColor = System.Drawing.Color.Blue;
            this.ItemNumTb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemNumTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(39)))));
            this.ItemNumTb.Location = new System.Drawing.Point(242, 87);
            this.ItemNumTb.Name = "ItemNumTb";
            this.ItemNumTb.Size = new System.Drawing.Size(222, 32);
            this.ItemNumTb.TabIndex = 2;
            // 
            // ItemsGV
            // 
            this.ItemsGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.Location = new System.Drawing.Point(481, 60);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowTemplate.Height = 25;
            this.ItemsGV.Size = new System.Drawing.Size(443, 716);
            this.ItemsGV.TabIndex = 1;
            // 
            // CatCb
            // 
            this.CatCb.BackColor = System.Drawing.Color.Blue;
            this.CatCb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(39)))));
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.CatCb.Location = new System.Drawing.Point(242, 172);
            this.CatCb.Name = "CatCb";
            this.CatCb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CatCb.Size = new System.Drawing.Size(222, 38);
            this.CatCb.TabIndex = 0;
            this.CatCb.Text = "Категории";
            this.CatCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.label6.Font = new System.Drawing.Font("Brandish", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1066, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 43);
            this.label6.TabIndex = 14;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(142)))));
            this.label5.Font = new System.Drawing.Font("Balthazar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.label5.Location = new System.Drawing.Point(14, 826);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Выйти";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(39)))));
            this.button4.Location = new System.Drawing.Point(3, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 50);
            this.button4.TabIndex = 19;
            this.button4.Text = "Пользователи";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(242)))), ((int)(((byte)(39)))));
            this.button3.Location = new System.Drawing.Point(2, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 50);
            this.button3.TabIndex = 18;
            this.button3.Text = "Заказы";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(213)))), ((int)(((byte)(142)))));
            this.label2.Font = new System.Drawing.Font("Balthazar", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(83)))));
            this.label2.Location = new System.Drawing.Point(529, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Управление товарами";
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1120, 850);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox PriceTb;
        private TextBox ItemNameTb;
        private TextBox ItemNumTb;
        private DataGridView ItemsGV;
        private ComboBox CatCb;
        private Label label6;
        private Label label5;
        private Button button4;
        private Button button3;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button button2;
        private Label label7;
        private Label label2;
        private Label label8;
        private Button button5;
    }
}