﻿namespace WinFormsApp1
{
    partial class tres
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 0;
            label1.Text = "x= ax^2+bx+c";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(30, 72);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 1;
            label2.Text = "INGRESA VALOR DE A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(30, 105);
            label3.Name = "label3";
            label3.Size = new Size(167, 21);
            label3.TabIndex = 2;
            label3.Text = "INGRESA VALOR DE B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(30, 139);
            label4.Name = "label4";
            label4.Size = new Size(167, 21);
            label4.TabIndex = 3;
            label4.Text = "INGRESA VALOR DE C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(29, 230);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 4;
            label5.Text = "RESULTADO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(132, 230);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(204, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(108, 29);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(203, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(108, 29);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox3.ForeColor = Color.Red;
            textBox3.Location = new Point(204, 140);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 29);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(30, 264);
            button1.Name = "button1";
            button1.Size = new Size(104, 37);
            button1.TabIndex = 9;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox4.ForeColor = Color.Red;
            textBox4.Location = new Point(204, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(108, 29);
            textBox4.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(29, 177);
            label7.Name = "label7";
            label7.Size = new Size(167, 21);
            label7.TabIndex = 11;
            label7.Text = "INGRESA VALOR DE X";
            // 
            // tres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(366, 335);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.MidnightBlue;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "tres";
            Text = "ECUACION 3";
            Load += tres_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private TextBox textBox4;
        private Label label7;
    }
}