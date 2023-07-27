namespace _10_Struct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pBoxMoon = new PictureBox();
            pBoxStar = new PictureBox();
            pBoxNone = new PictureBox();
            pBoxSun = new PictureBox();
            rbP1 = new RadioButton();
            rbP2 = new RadioButton();
            lBoxRst1 = new ListBox();
            lBoxRst2 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pBoxMoon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxNone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSun).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 50);
            label1.Name = "label1";
            label1.Size = new Size(508, 32);
            label1.TabIndex = 0;
            label1.Text = "Player는 한번 씩 돌아가며 그림을 선택하세요.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 82);
            label2.Name = "label2";
            label2.Size = new Size(775, 32);
            label2.TabIndex = 1;
            label2.Text = "각 10회 진행한 후 해, 달, 별의 숫자 합이 가장 높은 사람이 승리합니다.";
            // 
            // pBoxMoon
            // 
            pBoxMoon.Image = (Image)resources.GetObject("pBoxMoon.Image");
            pBoxMoon.Location = new Point(268, 157);
            pBoxMoon.Name = "pBoxMoon";
            pBoxMoon.Size = new Size(200, 306);
            pBoxMoon.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxMoon.TabIndex = 3;
            pBoxMoon.TabStop = false;
            pBoxMoon.Click += pBoxMoon_Click;
            // 
            // pBoxStar
            // 
            pBoxStar.Image = (Image)resources.GetObject("pBoxStar.Image");
            pBoxStar.Location = new Point(505, 157);
            pBoxStar.Name = "pBoxStar";
            pBoxStar.Size = new Size(200, 306);
            pBoxStar.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxStar.TabIndex = 4;
            pBoxStar.TabStop = false;
            pBoxStar.Click += pBoxStar_Click;
            // 
            // pBoxNone
            // 
            pBoxNone.BackColor = SystemColors.ControlDark;
            pBoxNone.Location = new Point(750, 157);
            pBoxNone.Name = "pBoxNone";
            pBoxNone.Size = new Size(200, 306);
            pBoxNone.TabIndex = 5;
            pBoxNone.TabStop = false;
            pBoxNone.Click += pBoxNone_Click;
            // 
            // pBoxSun
            // 
            pBoxSun.Image = (Image)resources.GetObject("pBoxSun.Image");
            pBoxSun.Location = new Point(28, 157);
            pBoxSun.Name = "pBoxSun";
            pBoxSun.Size = new Size(200, 306);
            pBoxSun.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSun.TabIndex = 6;
            pBoxSun.TabStop = false;
            pBoxSun.Click += pBoxSun_Click;
            // 
            // rbP1
            // 
            rbP1.AutoSize = true;
            rbP1.Location = new Point(28, 563);
            rbP1.Name = "rbP1";
            rbP1.Size = new Size(123, 36);
            rbP1.TabIndex = 7;
            rbP1.TabStop = true;
            rbP1.Text = "Player1";
            rbP1.UseVisualStyleBackColor = true;
            // 
            // rbP2
            // 
            rbP2.AutoSize = true;
            rbP2.Location = new Point(826, 563);
            rbP2.Name = "rbP2";
            rbP2.Size = new Size(123, 36);
            rbP2.TabIndex = 8;
            rbP2.TabStop = true;
            rbP2.Text = "Player2";
            rbP2.UseVisualStyleBackColor = true;
            // 
            // lBoxRst1
            // 
            lBoxRst1.FormattingEnabled = true;
            lBoxRst1.ItemHeight = 32;
            lBoxRst1.Location = new Point(28, 605);
            lBoxRst1.Name = "lBoxRst1";
            lBoxRst1.Size = new Size(761, 260);
            lBoxRst1.TabIndex = 11;
            // 
            // lBoxRst2
            // 
            lBoxRst2.FormattingEnabled = true;
            lBoxRst2.ItemHeight = 32;
            lBoxRst2.Location = new Point(826, 605);
            lBoxRst2.Name = "lBoxRst2";
            lBoxRst2.Size = new Size(775, 260);
            lBoxRst2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1647, 909);
            Controls.Add(lBoxRst2);
            Controls.Add(lBoxRst1);
            Controls.Add(rbP2);
            Controls.Add(rbP1);
            Controls.Add(pBoxSun);
            Controls.Add(pBoxNone);
            Controls.Add(pBoxStar);
            Controls.Add(pBoxMoon);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pBoxMoon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxNone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pBoxMoon;
        private PictureBox pBoxStar;
        private PictureBox pBoxNone;
        private PictureBox pBoxSun;
        private RadioButton rbP1;
        private RadioButton rbP2;
        private ListBox lBoxRst1;
        private ListBox lBoxRst2;
    }
}