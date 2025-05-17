namespace WinFormsApp1
{
    partial class doce
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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.Teal;
            textBox1.Location = new Point(117, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 20;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(24, 173);
            button2.Name = "button2";
            button2.Size = new Size(98, 32);
            button2.TabIndex = 19;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(128, 90);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(21, 90);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 17;
            label3.Text = "RESULTADO:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(24, 131);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 16;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(21, 57);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 15;
            label2.Text = "INGRESA X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 14;
            label1.Text = "x^2+x^3+x^4";
            // 
            // doce
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 254);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "doce";
            Text = "ECUACION 12";
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
    }
}