namespace _03_Method
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
            tBoxResult = new TextBox();
            tBoxNum1 = new TextBox();
            tBoxNum2 = new TextBox();
            btnSum = new Button();
            btnSub = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            SuspendLayout();
            // 
            // tBoxResult
            // 
            tBoxResult.Enabled = false;
            tBoxResult.Location = new Point(21, 24);
            tBoxResult.Name = "tBoxResult";
            tBoxResult.Size = new Size(561, 39);
            tBoxResult.TabIndex = 0;
            tBoxResult.Text = "0";
            tBoxResult.TextAlign = HorizontalAlignment.Right;
            tBoxResult.TextChanged += textBox1_TextChanged;
            // 
            // tBoxNum1
            // 
            tBoxNum1.Location = new Point(21, 103);
            tBoxNum1.Name = "tBoxNum1";
            tBoxNum1.Size = new Size(274, 39);
            tBoxNum1.TabIndex = 1;
            tBoxNum1.Text = "0";
            tBoxNum1.TextAlign = HorizontalAlignment.Right;
            // 
            // tBoxNum2
            // 
            tBoxNum2.Location = new Point(308, 103);
            tBoxNum2.Name = "tBoxNum2";
            tBoxNum2.Size = new Size(274, 39);
            tBoxNum2.TabIndex = 2;
            tBoxNum2.Text = "0";
            tBoxNum2.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(21, 191);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(97, 73);
            btnSum.TabIndex = 3;
            btnSum.Text = "+";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(165, 191);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(97, 73);
            btnSub.TabIndex = 4;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(337, 191);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(97, 73);
            btnDiv.TabIndex = 5;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(485, 191);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(97, 73);
            btnMul.TabIndex = 6;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 384);
            Controls.Add(btnMul);
            Controls.Add(btnDiv);
            Controls.Add(btnSub);
            Controls.Add(btnSum);
            Controls.Add(tBoxNum2);
            Controls.Add(tBoxNum1);
            Controls.Add(tBoxResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxResult;
        private TextBox tBoxNum1;
        private TextBox tBoxNum2;
        private Button btnSum;
        private Button btnSub;
        private Button btnDiv;
        private Button btnMul;
    }
}