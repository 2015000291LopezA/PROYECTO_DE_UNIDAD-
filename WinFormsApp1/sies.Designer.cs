namespace WinFormsApp1
{
    partial class sies
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.SlateGray;
            label1.Location = new Point(34, 29);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 0;
            label1.Text = "X = D^3+X^2+X+1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(34, 72);
            label2.Name = "label2";
            label2.Size = new Size(188, 21);
            label2.TabIndex = 1;
            label2.Text = "INGRESA EL VALOR DE D";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(34, 112);
            label3.Name = "label3";
            label3.Size = new Size(187, 21);
            label3.TabIndex = 2;
            label3.Text = "INGRESA EL VALOR DE X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.SlateGray;
            label4.Location = new Point(34, 149);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 3;
            label4.Text = "RESULTADO";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.SlateGray;
            button1.Location = new Point(34, 182);
            button1.Name = "button1";
            button1.Size = new Size(97, 31);
            button1.TabIndex = 4;
            button1.Text = "GENERAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox1.ForeColor = Color.SlateGray;
            textBox1.Location = new Point(228, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 29);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            textBox2.ForeColor = Color.SlateGray;
            textBox2.Location = new Point(228, 109);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 29);
            textBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.SlateGray;
            button2.Location = new Point(34, 223);
            button2.Name = "button2";
            button2.Size = new Size(97, 31);
            button2.TabIndex = 7;
            button2.Text = "LIMPIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = Color.SlateGray;
            label5.Location = new Point(137, 149);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 8;
            // 
            // sies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(410, 307);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "sies";
            Text = "ECUACION 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label5;
    }
}