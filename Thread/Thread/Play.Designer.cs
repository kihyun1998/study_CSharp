namespace study_Thread
{
    partial class Play
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
            lbPlayerName = new Label();
            pBar = new ProgressBar();
            lblProgress = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbPlayerName
            // 
            lbPlayerName.AutoSize = true;
            lbPlayerName.Location = new Point(24, 9);
            lbPlayerName.Name = "lbPlayerName";
            lbPlayerName.Size = new Size(151, 32);
            lbPlayerName.TabIndex = 0;
            lbPlayerName.Text = "Player Name";
            // 
            // pBar
            // 
            pBar.Location = new Point(24, 55);
            pBar.Name = "pBar";
            pBar.Size = new Size(911, 46);
            pBar.TabIndex = 1;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(689, 9);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(228, 32);
            lblProgress.TabIndex = 2;
            lblProgress.Text = "진행 상황 표시 : 0%";
            // 
            // button1
            // 
            button1.Location = new Point(411, 4);
            button1.Name = "button1";
            button1.Size = new Size(173, 42);
            button1.TabIndex = 3;
            button1.Text = "Give up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 129);
            Controls.Add(button1);
            Controls.Add(lblProgress);
            Controls.Add(pBar);
            Controls.Add(lbPlayerName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Play";
            Text = "Play";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPlayerName;
        private ProgressBar pBar;
        private Label lblProgress;
        private Button button1;
    }
}