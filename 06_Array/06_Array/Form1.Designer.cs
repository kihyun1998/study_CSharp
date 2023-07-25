namespace _06_Array
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
            dgDay = new DataGridView();
            colDay1 = new DataGridViewTextBoxColumn();
            colDay2 = new DataGridViewTextBoxColumn();
            colDay3 = new DataGridViewTextBoxColumn();
            colDay4 = new DataGridViewTextBoxColumn();
            colDay5 = new DataGridViewTextBoxColumn();
            colDay6 = new DataGridViewTextBoxColumn();
            colDay7 = new DataGridViewTextBoxColumn();
            btn1 = new Button();
            btn2 = new Button();
            lblArrCnt = new Label();
            ((System.ComponentModel.ISupportInitialize)dgDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 50);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 0;
            label1.Text = "매장 방문 수";
            // 
            // dgDay
            // 
            dgDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDay.Columns.AddRange(new DataGridViewColumn[] { colDay1, colDay2, colDay3, colDay4, colDay5, colDay6, colDay7 });
            dgDay.Location = new Point(72, 98);
            dgDay.Name = "dgDay";
            dgDay.RowHeadersWidth = 82;
            dgDay.RowTemplate.Height = 41;
            dgDay.Size = new Size(1489, 226);
            dgDay.TabIndex = 1;
            // 
            // colDay1
            // 
            colDay1.HeaderText = "월";
            colDay1.MinimumWidth = 10;
            colDay1.Name = "colDay1";
            colDay1.Width = 200;
            // 
            // colDay2
            // 
            colDay2.HeaderText = "화";
            colDay2.MinimumWidth = 10;
            colDay2.Name = "colDay2";
            colDay2.Width = 200;
            // 
            // colDay3
            // 
            colDay3.HeaderText = "수";
            colDay3.MinimumWidth = 10;
            colDay3.Name = "colDay3";
            colDay3.Width = 200;
            // 
            // colDay4
            // 
            colDay4.HeaderText = "목";
            colDay4.MinimumWidth = 10;
            colDay4.Name = "colDay4";
            colDay4.Width = 200;
            // 
            // colDay5
            // 
            colDay5.HeaderText = "금";
            colDay5.MinimumWidth = 10;
            colDay5.Name = "colDay5";
            colDay5.Width = 200;
            // 
            // colDay6
            // 
            colDay6.HeaderText = "토";
            colDay6.MinimumWidth = 10;
            colDay6.Name = "colDay6";
            colDay6.Width = 200;
            // 
            // colDay7
            // 
            colDay7.HeaderText = "일";
            colDay7.MinimumWidth = 10;
            colDay7.Name = "colDay7";
            colDay7.Width = 200;
            // 
            // btn1
            // 
            btn1.Location = new Point(72, 330);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 46);
            btn1.TabIndex = 2;
            btn1.Text = "일주일간";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(279, 330);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 46);
            btn2.TabIndex = 3;
            btn2.Text = "이주일간";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // lblArrCnt
            // 
            lblArrCnt.AutoSize = true;
            lblArrCnt.Location = new Point(542, 344);
            lblArrCnt.Name = "lblArrCnt";
            lblArrCnt.Size = new Size(150, 32);
            lblArrCnt.TabIndex = 4;
            lblArrCnt.Text = "전체 자료 수";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 450);
            Controls.Add(lblArrCnt);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(dgDay);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgDay;
        private DataGridViewTextBoxColumn colDay1;
        private DataGridViewTextBoxColumn colDay2;
        private DataGridViewTextBoxColumn colDay3;
        private DataGridViewTextBoxColumn colDay4;
        private DataGridViewTextBoxColumn colDay6;
        private DataGridViewTextBoxColumn colDay7;
        private Button btn1;
        private Button btn2;
        private Label lblArrCnt;
        private DataGridViewTextBoxColumn colDay5;
    }
}