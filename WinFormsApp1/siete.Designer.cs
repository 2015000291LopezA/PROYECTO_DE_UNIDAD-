﻿namespace WinFormsApp1
{
    partial class siete
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Chartreuse;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 0;
            label1.Text = "X = D^3+ax^2+bx+1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(34, 68);
            label2.Name = "label2";
            label2.Size = new Size(185, 21);
            label2.TabIndex = 1;
            label2.Text = "INGRESE EL VALOR DE D";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Chartreuse;
            label3.Location = new Point(34, 110);
            label3.Name = "label3";
            label3.Size = new Size(185, 21);
            label3.TabIndex = 2;
            label3.Text = "INGRESE EL VALOR DE A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Chartreuse;
            label4.Location = new Point(34, 151);
            label4.Name = "label4";
            label4.Size = new Size(184, 21);
            label4.TabIndex = 3;
            label4.Text = "INGRESE EL VALOR DE B";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Chartreuse;
            label5.Location = new Point(34, 188);
            label5.Name = "label5";
            label5.Size = new Size(184, 21);
            label5.TabIndex = 4;
            label5.Text = "INGRESE EL VALOR DE X";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 0);
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.Chartreuse;
            textBox1.Location = new Point(225, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(64, 64, 0);
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox2.ForeColor = Color.Chartreuse;
            textBox2.Location = new Point(225, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(64, 64, 0);
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox3.ForeColor = Color.Chartreuse;
            textBox3.Location = new Point(225, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(64, 64, 0);
            textBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox4.ForeColor = Color.Chartreuse;
            textBox4.Location = new Point(225, 188);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 29);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Chartreuse;
            label6.Location = new Point(34, 227);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 9;
            label6.Text = "RESULTADO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Chartreuse;
            label7.Location = new Point(147, 227);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 0);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Chartreuse;
            button1.Location = new Point(34, 268);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(97, 34);
            button1.TabIndex = 11;
            button1.Text = "GENERAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 0);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Chartreuse;
            button2.Location = new Point(34, 307);
            button2.Name = "button2";
            button2.Size = new Size(97, 34);
            button2.TabIndex = 12;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // siete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(402, 363);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "siete";
            Text = "ECUACION 7";
            Load += siete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}