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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            Success = new Label();
            Failed = new Label();
            Skip = new Button();
            Hint = new Button();
            Restart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            Timer = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
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
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Trebuchet MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(698, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 34);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(721, 402);
            button1.Name = "button1";
            button1.Size = new Size(100, 70);
            button1.TabIndex = 2;
            button1.Text = "Провери";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Success
            // 
            Success.AutoSize = true;
            Success.BackColor = Color.Transparent;
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
            Failed.BackColor = Color.Transparent;
            Failed.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Failed.ForeColor = SystemColors.ButtonFace;
            Failed.Location = new Point(1237, 68);
            Failed.Name = "Failed";
            Failed.Size = new Size(128, 22);
            Failed.TabIndex = 4;
            Failed.Text = "Сгрешени: 0";
            // 
            // Skip
            // 
            Skip.BackColor = SystemColors.ButtonFace;
            Skip.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Skip.Location = new Point(931, 402);
            Skip.Name = "Skip";
            Skip.Size = new Size(95, 70);
            Skip.TabIndex = 5;
            Skip.Text = "Пропусни";
            Skip.UseVisualStyleBackColor = false;
            Skip.Click += Skip_Click;
            // 
            // Hint
            // 
            Hint.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Hint.Location = new Point(552, 402);
            Hint.Name = "Hint";
            Hint.Size = new Size(70, 70);
            Hint.TabIndex = 6;
            Hint.Text = "Жокер";
            Hint.UseVisualStyleBackColor = true;
            Hint.Click += Hint_Click;
            // 
            // Restart
            // 
            Restart.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Restart.Location = new Point(708, 512);
            Restart.Name = "Restart";
            Restart.Size = new Size(126, 70);
            Restart.TabIndex = 7;
            Restart.Text = "Рестартирай";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += Restart_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Timer
            // 
            Timer.AutoSize = true;
            Timer.BackColor = Color.Transparent;
            Timer.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Timer.ForeColor = Color.White;
            Timer.Location = new Point(724, 280);
            Timer.Name = "Timer";
            Timer.Size = new Size(85, 18);
            Timer.TabIndex = 8;
            Timer.Text = "Време: 60";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.zigzag_cover;
            ClientSize = new Size(1444, 723);
            Controls.Add(Timer);
            Controls.Add(Restart);
            Controls.Add(Hint);
            Controls.Add(Skip);
            Controls.Add(Failed);
            Controls.Add(Success);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label Success;
        private Label Failed;
        private Button Skip;
        private Button Hint;
        private Button Restart;
        private System.Windows.Forms.Timer timer1;
        private Label Timer;
    }
}
