namespace World_Scramble
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
            textBox1 = new TextBox();
            button1 = new Button();
            Success = new Label();
            Failed = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(708, 226);
            label1.Name = "label1";
            label1.Size = new Size(113, 34);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDark;
            textBox1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(698, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(708, 398);
            button1.Name = "button1";
            button1.Size = new Size(115, 29);
            button1.TabIndex = 2;
            button1.Text = "Провери";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Success
            // 
            Success.AutoSize = true;
            Success.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Success.ForeColor = SystemColors.ButtonFace;
            Success.Location = new Point(67, 69);
            Success.Name = "Success";
            Success.Size = new Size(111, 22);
            Success.TabIndex = 3;
            Success.Text = "Познати: 0";
            // 
            // Failed
            // 
            Failed.AutoSize = true;
            Failed.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Failed.ForeColor = SystemColors.ButtonFace;
            Failed.Location = new Point(1237, 68);
            Failed.Name = "Failed";
            Failed.Size = new Size(128, 22);
            Failed.TabIndex = 4;
            Failed.Text = "Сгрешени: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1444, 723);
            Controls.Add(Failed);
            Controls.Add(Success);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label Success;
        private Label Failed;
    }
}
