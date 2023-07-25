namespace _07_if
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
            btnIfRst = new Button();
            btnSwRst = new Button();
            label1 = new Label();
            label2 = new Label();
            lblIfRst = new Label();
            nNum1 = new NumericUpDown();
            nNum2 = new NumericUpDown();
            label4 = new Label();
            cBoxDay = new ComboBox();
            lblSwRst = new Label();
            ((System.ComponentModel.ISupportInitialize)nNum1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nNum2).BeginInit();
            SuspendLayout();
            // 
            // btnIfRst
            // 
            btnIfRst.Location = new Point(594, 140);
            btnIfRst.Name = "btnIfRst";
            btnIfRst.Size = new Size(228, 46);
            btnIfRst.TabIndex = 0;
            btnIfRst.Text = "Number 비교";
            btnIfRst.UseVisualStyleBackColor = true;
            btnIfRst.Click += btnIfRst_Click;
            // 
            // btnSwRst
            // 
            btnSwRst.Location = new Point(594, 501);
            btnSwRst.Name = "btnSwRst";
            btnSwRst.Size = new Size(228, 46);
            btnSwRst.TabIndex = 1;
            btnSwRst.Text = "선택";
            btnSwRst.UseVisualStyleBackColor = true;
            btnSwRst.Click += btnSwRst_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(115, 69);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 2;
            label1.Text = "Num1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 69);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 3;
            label2.Text = "Num2";
            // 
            // lblIfRst
            // 
            lblIfRst.AutoSize = true;
            lblIfRst.Location = new Point(115, 289);
            lblIfRst.Name = "lblIfRst";
            lblIfRst.Size = new Size(24, 32);
            lblIfRst.TabIndex = 4;
            lblIfRst.Text = "-";
            // 
            // nNum1
            // 
            nNum1.Location = new Point(72, 147);
            nNum1.Name = "nNum1";
            nNum1.Size = new Size(123, 39);
            nNum1.TabIndex = 5;
            // 
            // nNum2
            // 
            nNum2.Location = new Point(302, 147);
            nNum2.Name = "nNum2";
            nNum2.Size = new Size(123, 39);
            nNum2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 400);
            label4.Name = "label4";
            label4.Size = new Size(118, 32);
            label4.TabIndex = 7;
            label4.Text = "요일 선택";
            // 
            // cBoxDay
            // 
            cBoxDay.FormattingEnabled = true;
            cBoxDay.Items.AddRange(new object[] { "월", "화", "수", "목", "금", "토", "일" });
            cBoxDay.Location = new Point(115, 491);
            cBoxDay.Name = "cBoxDay";
            cBoxDay.Size = new Size(242, 40);
            cBoxDay.TabIndex = 8;
            // 
            // lblSwRst
            // 
            lblSwRst.AutoSize = true;
            lblSwRst.Location = new Point(115, 601);
            lblSwRst.Name = "lblSwRst";
            lblSwRst.Size = new Size(24, 32);
            lblSwRst.TabIndex = 9;
            lblSwRst.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 732);
            Controls.Add(lblSwRst);
            Controls.Add(cBoxDay);
            Controls.Add(label4);
            Controls.Add(nNum2);
            Controls.Add(nNum1);
            Controls.Add(lblIfRst);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSwRst);
            Controls.Add(btnIfRst);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nNum1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nNum2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIfRst;
        private Button btnSwRst;
        private Label label1;
        private Label label2;
        private Label lblIfRst;
        private NumericUpDown nNum1;
        private NumericUpDown nNum2;
        private Label label4;
        private ComboBox cBoxDay;
        private Label lblSwRst;
    }
}