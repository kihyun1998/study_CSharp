namespace _02_DataType
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
            btnMain = new Button();
            label1 = new Label();
            tboxNumber = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblShort = new Label();
            lblint = new Label();
            lblDouble = new Label();
            lblException = new Label();
            btnShort = new Button();
            btnint = new Button();
            btnDouble = new Button();
            SuspendLayout();
            // 
            // btnMain
            // 
            btnMain.Location = new Point(665, 76);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(150, 46);
            btnMain.TabIndex = 0;
            btnMain.Text = "Auto";
            btnMain.UseVisualStyleBackColor = true;
            btnMain.Click += btnMain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 251);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 1;
            label1.Text = "Short";
            label1.Click += label1_Click;
            // 
            // tboxNumber
            // 
            tboxNumber.Location = new Point(92, 76);
            tboxNumber.Name = "tboxNumber";
            tboxNumber.Size = new Size(481, 39);
            tboxNumber.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 320);
            label2.Name = "label2";
            label2.Size = new Size(42, 32);
            label2.TabIndex = 3;
            label2.Text = "int";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 389);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 4;
            label3.Text = "Double";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 460);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 5;
            label4.Text = "Exception";
            // 
            // lblShort
            // 
            lblShort.AutoSize = true;
            lblShort.Location = new Point(278, 251);
            lblShort.Name = "lblShort";
            lblShort.Size = new Size(27, 32);
            lblShort.TabIndex = 6;
            lblShort.Text = "0";
            // 
            // lblint
            // 
            lblint.AutoSize = true;
            lblint.Location = new Point(278, 320);
            lblint.Name = "lblint";
            lblint.Size = new Size(27, 32);
            lblint.TabIndex = 7;
            lblint.Text = "0";
            // 
            // lblDouble
            // 
            lblDouble.AutoSize = true;
            lblDouble.Location = new Point(278, 389);
            lblDouble.Name = "lblDouble";
            lblDouble.Size = new Size(27, 32);
            lblDouble.TabIndex = 8;
            lblDouble.Text = "0";
            // 
            // lblException
            // 
            lblException.AutoSize = true;
            lblException.Location = new Point(278, 460);
            lblException.Name = "lblException";
            lblException.Size = new Size(24, 32);
            lblException.TabIndex = 9;
            lblException.Text = "-";
            // 
            // btnShort
            // 
            btnShort.Location = new Point(498, 251);
            btnShort.Name = "btnShort";
            btnShort.Size = new Size(150, 46);
            btnShort.TabIndex = 10;
            btnShort.Text = "To Short";
            btnShort.UseVisualStyleBackColor = true;
            btnShort.Click += btnShort_Click;
            // 
            // btnint
            // 
            btnint.Location = new Point(498, 313);
            btnint.Name = "btnint";
            btnint.Size = new Size(150, 46);
            btnint.TabIndex = 11;
            btnint.Text = "To int";
            btnint.UseVisualStyleBackColor = true;
            btnint.Click += btnint_Click;
            // 
            // btnDouble
            // 
            btnDouble.Location = new Point(498, 389);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(150, 46);
            btnDouble.TabIndex = 12;
            btnDouble.Text = "To Double";
            btnDouble.UseVisualStyleBackColor = true;
            btnDouble.Click += btnDouble_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 786);
            Controls.Add(btnDouble);
            Controls.Add(btnint);
            Controls.Add(btnShort);
            Controls.Add(lblException);
            Controls.Add(lblDouble);
            Controls.Add(lblint);
            Controls.Add(lblShort);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tboxNumber);
            Controls.Add(label1);
            Controls.Add(btnMain);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMain;
        private Label label1;
        private TextBox tboxNumber;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblShort;
        private Label lblint;
        private Label lblDouble;
        private Label lblException;
        private Button btnShort;
        private Button btnint;
        private Button btnDouble;
    }
}