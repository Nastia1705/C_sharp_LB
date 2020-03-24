namespace WindowsFormsApp5
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.b16 = new System.Windows.Forms.Button();
            this.b15 = new System.Windows.Forms.Button();
            this.b14 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 490);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(282, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Видалити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(180, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(31, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.b16);
            this.tabPage2.Controls.Add(this.b15);
            this.tabPage2.Controls.Add(this.b14);
            this.tabPage2.Controls.Add(this.b13);
            this.tabPage2.Controls.Add(this.b12);
            this.tabPage2.Controls.Add(this.b11);
            this.tabPage2.Controls.Add(this.b10);
            this.tabPage2.Controls.Add(this.b9);
            this.tabPage2.Controls.Add(this.b8);
            this.tabPage2.Controls.Add(this.b7);
            this.tabPage2.Controls.Add(this.b6);
            this.tabPage2.Controls.Add(this.b5);
            this.tabPage2.Controls.Add(this.b4);
            this.tabPage2.Controls.Add(this.b3);
            this.tabPage2.Controls.Add(this.b2);
            this.tabPage2.Controls.Add(this.b1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(226, 298);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // b16
            // 
            this.b16.Location = new System.Drawing.Point(442, 218);
            this.b16.Name = "b16";
            this.b16.Size = new System.Drawing.Size(75, 23);
            this.b16.TabIndex = 15;
            this.b16.Text = "button15";
            this.b16.UseVisualStyleBackColor = true;
            this.b16.Click += new System.EventHandler(this.b1_Click);
            // 
            // b15
            // 
            this.b15.Location = new System.Drawing.Point(442, 167);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(75, 23);
            this.b15.TabIndex = 14;
            this.b15.Text = "button16";
            this.b15.UseVisualStyleBackColor = true;
            this.b15.Click += new System.EventHandler(this.b1_Click);
            // 
            // b14
            // 
            this.b14.Location = new System.Drawing.Point(442, 113);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(75, 23);
            this.b14.TabIndex = 13;
            this.b14.Text = "button17";
            this.b14.UseVisualStyleBackColor = true;
            this.b14.Click += new System.EventHandler(this.b1_Click);
            // 
            // b13
            // 
            this.b13.Location = new System.Drawing.Point(442, 63);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(75, 23);
            this.b13.TabIndex = 12;
            this.b13.Text = "button18";
            this.b13.UseVisualStyleBackColor = true;
            this.b13.Click += new System.EventHandler(this.b1_Click);
            // 
            // b12
            // 
            this.b12.Location = new System.Drawing.Point(314, 218);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(75, 23);
            this.b12.TabIndex = 11;
            this.b12.Text = "button11";
            this.b12.UseVisualStyleBackColor = true;
            this.b12.Click += new System.EventHandler(this.b1_Click);
            // 
            // b11
            // 
            this.b11.Location = new System.Drawing.Point(314, 167);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(75, 23);
            this.b11.TabIndex = 10;
            this.b11.Text = "button12";
            this.b11.UseVisualStyleBackColor = true;
            this.b11.Click += new System.EventHandler(this.b1_Click);
            // 
            // b10
            // 
            this.b10.Location = new System.Drawing.Point(314, 113);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(75, 23);
            this.b10.TabIndex = 9;
            this.b10.Text = "button13";
            this.b10.UseVisualStyleBackColor = true;
            this.b10.Click += new System.EventHandler(this.b1_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(314, 63);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 23);
            this.b9.TabIndex = 8;
            this.b9.Text = "button14";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b1_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(189, 218);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 23);
            this.b8.TabIndex = 7;
            this.b8.Text = "button7";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b1_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(189, 167);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 23);
            this.b7.TabIndex = 6;
            this.b7.Text = "button8";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b1_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(189, 113);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 23);
            this.b6.TabIndex = 5;
            this.b6.Text = "button9";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b1_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(189, 63);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 23);
            this.b5.TabIndex = 4;
            this.b5.Text = "button10";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b1_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(67, 218);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 23);
            this.b4.TabIndex = 3;
            this.b4.Text = "button6";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(67, 167);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 2;
            this.b3.Text = "button5";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(67, 113);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 1;
            this.b2.Text = "button4";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b1_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(67, 63);
            this.b1.Name = "b1";
            this.b1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "button3";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 495);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button b16;
        private System.Windows.Forms.Button b15;
        private System.Windows.Forms.Button b14;
        private System.Windows.Forms.Button b13;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

