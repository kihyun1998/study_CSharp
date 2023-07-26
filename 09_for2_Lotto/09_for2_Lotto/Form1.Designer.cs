namespace _09_for2_Lotto
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
            lblWhileRst = new Label();
            btnWhileRst = new Button();
            lBoxWhileRst = new ListBox();
            tBoxRst = new Label();
            tBoxNum = new TextBox();
            btnDoWhileRst = new Button();
            lblDoWhileRst = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblWhileRst
            // 
            lblWhileRst.AutoSize = true;
            lblWhileRst.BackColor = SystemColors.Highlight;
            lblWhileRst.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lblWhileRst.ForeColor = SystemColors.ButtonHighlight;
            lblWhileRst.Location = new Point(12, 46);
            lblWhileRst.Name = "lblWhileRst";
            lblWhileRst.Size = new Size(255, 50);
            lblWhileRst.TabIndex = 0;
            lblWhileRst.Text = "0. 0. 0. 0. 0. 0.";
            lblWhileRst.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnWhileRst
            // 
            btnWhileRst.Location = new Point(429, 38);
            btnWhileRst.Name = "btnWhileRst";
            btnWhileRst.Size = new Size(208, 78);
            btnWhileRst.TabIndex = 1;
            btnWhileRst.Text = "로또 번호 생성";
            btnWhileRst.UseVisualStyleBackColor = true;
            btnWhileRst.Click += btnWhileRst_Click;
            // 
            // lBoxWhileRst
            // 
            lBoxWhileRst.FormattingEnabled = true;
            lBoxWhileRst.ItemHeight = 32;
            lBoxWhileRst.Location = new Point(59, 133);
            lBoxWhileRst.Name = "lBoxWhileRst";
            lBoxWhileRst.Size = new Size(530, 420);
            lBoxWhileRst.TabIndex = 2;
            // 
            // tBoxRst
            // 
            tBoxRst.AutoSize = true;
            tBoxRst.Location = new Point(59, 582);
            tBoxRst.Name = "tBoxRst";
            tBoxRst.Size = new Size(368, 32);
            tBoxRst.TabIndex = 3;
            tBoxRst.Text = "1 ~ 100 안의 숫자를 입력하세요.";
            // 
            // tBoxNum
            // 
            tBoxNum.Location = new Point(59, 637);
            tBoxNum.Name = "tBoxNum";
            tBoxNum.Size = new Size(108, 39);
            tBoxNum.TabIndex = 4;
            tBoxNum.Text = "1";
            tBoxNum.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDoWhileRst
            // 
            btnDoWhileRst.Location = new Point(251, 630);
            btnDoWhileRst.Name = "btnDoWhileRst";
            btnDoWhileRst.Size = new Size(208, 52);
            btnDoWhileRst.TabIndex = 5;
            btnDoWhileRst.Text = "선택 번호 뽑기";
            btnDoWhileRst.UseVisualStyleBackColor = true;
            btnDoWhileRst.Click += btnDoWhileRst_Click;
            // 
            // lblDoWhileRst
            // 
            lblDoWhileRst.AutoSize = true;
            lblDoWhileRst.Location = new Point(59, 723);
            lblDoWhileRst.Name = "lblDoWhileRst";
            lblDoWhileRst.Size = new Size(24, 32);
            lblDoWhileRst.TabIndex = 6;
            lblDoWhileRst.Text = "-";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Font = new Font("맑은 고딕", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(12, 569);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 10);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(649, 810);
            Controls.Add(panel1);
            Controls.Add(lblDoWhileRst);
            Controls.Add(btnDoWhileRst);
            Controls.Add(tBoxNum);
            Controls.Add(tBoxRst);
            Controls.Add(lBoxWhileRst);
            Controls.Add(btnWhileRst);
            Controls.Add(lblWhileRst);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWhileRst;
        private Button btnWhileRst;
        private ListBox lBoxWhileRst;
        private Label tBoxRst;
        private TextBox tBoxNum;
        private Button btnDoWhileRst;
        private Label lblDoWhileRst;
        private Panel panel1;
    }
}