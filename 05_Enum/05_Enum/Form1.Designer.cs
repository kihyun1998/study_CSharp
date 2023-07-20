namespace _05_Enum
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
            tBoxName = new TextBox();
            lBoxDay = new ListBox();
            lBoxTime = new ListBox();
            btnRst1 = new Button();
            btnRst2 = new Button();
            tBoxRst = new TextBox();
            SuspendLayout();
            // 
            // tBoxName
            // 
            tBoxName.Location = new Point(63, 62);
            tBoxName.Name = "tBoxName";
            tBoxName.Size = new Size(200, 39);
            tBoxName.TabIndex = 0;
            // 
            // lBoxDay
            // 
            lBoxDay.FormattingEnabled = true;
            lBoxDay.ItemHeight = 32;
            lBoxDay.Location = new Point(63, 159);
            lBoxDay.Name = "lBoxDay";
            lBoxDay.Size = new Size(279, 260);
            lBoxDay.TabIndex = 1;
            // 
            // lBoxTime
            // 
            lBoxTime.FormattingEnabled = true;
            lBoxTime.ItemHeight = 32;
            lBoxTime.Location = new Point(448, 159);
            lBoxTime.Name = "lBoxTime";
            lBoxTime.Size = new Size(279, 260);
            lBoxTime.TabIndex = 2;
            // 
            // btnRst1
            // 
            btnRst1.Location = new Point(63, 484);
            btnRst1.Name = "btnRst1";
            btnRst1.Size = new Size(150, 46);
            btnRst1.TabIndex = 3;
            btnRst1.Text = "결과";
            btnRst1.UseVisualStyleBackColor = true;
            btnRst1.Click += btnRst1_Click;
            // 
            // btnRst2
            // 
            btnRst2.Location = new Point(237, 484);
            btnRst2.Name = "btnRst2";
            btnRst2.Size = new Size(150, 46);
            btnRst2.TabIndex = 4;
            btnRst2.Text = "스트링 포맷";
            btnRst2.UseVisualStyleBackColor = true;
            btnRst2.Click += btnRst2_Click;
            // 
            // tBoxRst
            // 
            tBoxRst.Enabled = false;
            tBoxRst.Location = new Point(63, 565);
            tBoxRst.Multiline = true;
            tBoxRst.Name = "tBoxRst";
            tBoxRst.Size = new Size(664, 114);
            tBoxRst.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 706);
            Controls.Add(tBoxRst);
            Controls.Add(btnRst2);
            Controls.Add(btnRst1);
            Controls.Add(lBoxTime);
            Controls.Add(lBoxDay);
            Controls.Add(tBoxName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxName;
        private ListBox lBoxDay;
        private ListBox lBoxTime;
        private Button btnRst1;
        private Button btnRst2;
        private TextBox tBoxRst;
    }
}