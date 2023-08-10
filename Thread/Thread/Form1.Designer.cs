namespace study_Thread
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
            groupBox1 = new GroupBox();
            nPlayerCnt = new NumericUpDown();
            label1 = new Label();
            btnStart = new Button();
            lBoxRst = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nPlayerCnt).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nPlayerCnt);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(714, 154);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // nPlayerCnt
            // 
            nPlayerCnt.Location = new Point(251, 83);
            nPlayerCnt.Name = "nPlayerCnt";
            nPlayerCnt.Size = new Size(240, 39);
            nPlayerCnt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 85);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 0;
            label1.Text = "플레이어 수 :";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(602, 215);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 46);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lBoxRst
            // 
            lBoxRst.FormattingEnabled = true;
            lBoxRst.ItemHeight = 32;
            lBoxRst.Location = new Point(38, 296);
            lBoxRst.Name = "lBoxRst";
            lBoxRst.Size = new Size(714, 228);
            lBoxRst.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 614);
            Controls.Add(btnStart);
            Controls.Add(lBoxRst);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nPlayerCnt).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nPlayerCnt;
        private Label label1;
        private Button btnStart;
        private ListBox lBoxRst;
    }
}