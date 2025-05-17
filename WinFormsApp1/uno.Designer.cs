namespace WinFormsApp1
{
    partial class uno
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
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(55, 37);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 0;
            label1.Text = "X = X + 1";
            label1.UseWaitCursor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Khaki;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.OrangeRed;
            textBox1.Location = new Point(231, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 1;
            textBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(41, 94);
            label2.Name = "label2";
            label2.Size = new Size(184, 21);
            label2.TabIndex = 2;
            label2.Text = "INGRESE EL VALOR DE X";
            label2.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(41, 167);
            button1.Name = "button1";
            button1.Size = new Size(97, 37);
            button1.TabIndex = 3;
            button1.Text = "OPERAR";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.OrangeRed;
            button2.Location = new Point(41, 210);
            button2.Name = "button2";
            button2.Size = new Size(97, 37);
            button2.TabIndex = 4;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(62, 132);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 5;
            label3.Text = "RESULTADO";
            label3.UseWaitCursor = true;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(165, 132);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(0, 21);
            label4.TabIndex = 6;
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // uno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(428, 269);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "uno";
            Text = "Ecucacion 1 ";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
    }
}