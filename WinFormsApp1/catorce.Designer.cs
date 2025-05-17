namespace WinFormsApp1
{
    partial class catorce
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
            textBox1 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.SpringGreen;
            textBox1.Location = new Point(121, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 34;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.SpringGreen;
            button2.Location = new Point(28, 262);
            button2.Name = "button2";
            button2.Size = new Size(98, 32);
            button2.TabIndex = 33;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.SpringGreen;
            label4.Location = new Point(132, 179);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.SpringGreen;
            label3.Location = new Point(25, 179);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 31;
            label3.Text = "RESULTADO:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.SpringGreen;
            button1.Location = new Point(28, 220);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 30;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(25, 69);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 29;
            label2.Text = "INGRESA a";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 28;
            label1.Text = "ax+bx^2-abx";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox2.ForeColor = Color.SpringGreen;
            textBox2.Location = new Point(121, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.SpringGreen;
            label5.Location = new Point(25, 110);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 35;
            label5.Text = "INGRESA b";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox3.ForeColor = Color.SpringGreen;
            textBox3.Location = new Point(121, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.SpringGreen;
            label6.Location = new Point(25, 147);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 37;
            label6.Text = "INGRESA X";
            // 
            // catorce
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(348, 300);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLight;
            Name = "catorce";
            Text = "catorce";
            Load += catorce_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button2;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
    }
}