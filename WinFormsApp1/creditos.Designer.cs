﻿namespace WinFormsApp1
{
    partial class creditos
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.GreenYellow;
            label1.Location = new Point(61, 75);
            label1.Name = "label1";
            label1.Size = new Size(381, 32);
            label1.TabIndex = 0;
            label1.Text = "Santiago Alejandro Lopez Lopez";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.GreenYellow;
            label2.Location = new Point(119, 107);
            label2.Name = "label2";
            label2.Size = new Size(259, 32);
            label2.TabIndex = 1;
            label2.Text = "Quinto Bachillerato A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.GreenYellow;
            label3.Location = new Point(85, 30);
            label3.Name = "label3";
            label3.Size = new Size(343, 32);
            label3.TabIndex = 2;
            label3.Text = "PROYECTO PROGRAMACION";
            // 
            // creditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(538, 176);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.No;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "creditos";
            Text = "creditos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}