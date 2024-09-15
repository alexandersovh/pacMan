namespace pacMan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            exit = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(215, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 46);
            label1.TabIndex = 0;
            label1.Text = "PacMan";
            // 
            // exit
            // 
            exit.FlatStyle = FlatStyle.Flat;
            exit.ForeColor = Color.Yellow;
            exit.Location = new Point(407, 392);
            exit.Name = "exit";
            exit.Size = new Size(94, 29);
            exit.TabIndex = 2;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(10, 10, 10);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(66, 81);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(435, 289);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(570, 450);
            Controls.Add(textBox1);
            Controls.Add(exit);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button exit;
        private TextBox textBox1;
    }
}
