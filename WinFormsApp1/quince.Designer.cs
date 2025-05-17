namespace WinFormsApp1
{
    partial class quince
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
            textBox3 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox3.ForeColor = Color.Green;
            textBox3.Location = new Point(128, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(32, 65);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 48;
            label6.Text = "INGRESA X";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Green;
            button2.Location = new Point(35, 180);
            button2.Name = "button2";
            button2.Size = new Size(98, 32);
            button2.TabIndex = 44;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(139, 97);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(32, 97);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 42;
            label3.Text = "RESULTADO:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Green;
            button1.Location = new Point(35, 138);
            button1.Name = "button1";
            button1.Size = new Size(98, 36);
            button1.TabIndex = 41;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(111, 21);
            label1.TabIndex = 39;
            label1.Text = "x^6-x^7+x^8";
            // 
            // quince
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 272);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "quince";
            Text = "quince";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label6;
        private Button button2;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label1;
    }
}