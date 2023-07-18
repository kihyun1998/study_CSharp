namespace _04_Operator
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
            tboxRst = new TextBox();
            tboxRstAfter = new TextBox();
            tboxRstBit = new TextBox();
            tboxNum = new TextBox();
            tboxAo = new TextBox();
            btnls = new Button();
            btnrs = new Button();
            btnse = new Button();
            btnme = new Button();
            btnor = new Button();
            btnand = new Button();
            btnpost = new Button();
            btnpre = new Button();
            SuspendLayout();
            // 
            // tboxRst
            // 
            tboxRst.Location = new Point(75, 45);
            tboxRst.Name = "tboxRst";
            tboxRst.Size = new Size(200, 39);
            tboxRst.TabIndex = 0;
            tboxRst.Text = "0";
            tboxRst.TextAlign = HorizontalAlignment.Right;
            tboxRst.TextChanged += tboxRst_TextChanged;
            // 
            // tboxRstAfter
            // 
            tboxRstAfter.Location = new Point(338, 45);
            tboxRstAfter.Name = "tboxRstAfter";
            tboxRstAfter.Size = new Size(200, 39);
            tboxRstAfter.TabIndex = 1;
            tboxRstAfter.Text = "0";
            tboxRstAfter.TextAlign = HorizontalAlignment.Right;
            // 
            // tboxRstBit
            // 
            tboxRstBit.Enabled = false;
            tboxRstBit.Location = new Point(75, 124);
            tboxRstBit.Name = "tboxRstBit";
            tboxRstBit.Size = new Size(200, 39);
            tboxRstBit.TabIndex = 2;
            tboxRstBit.Text = "0";
            tboxRstBit.TextAlign = HorizontalAlignment.Right;
            // 
            // tboxNum
            // 
            tboxNum.Location = new Point(75, 216);
            tboxNum.Name = "tboxNum";
            tboxNum.Size = new Size(200, 39);
            tboxNum.TabIndex = 3;
            tboxNum.Text = "0";
            tboxNum.TextAlign = HorizontalAlignment.Right;
            // 
            // tboxAo
            // 
            tboxAo.Enabled = false;
            tboxAo.Location = new Point(338, 216);
            tboxAo.Name = "tboxAo";
            tboxAo.Size = new Size(200, 39);
            tboxAo.TabIndex = 4;
            // 
            // btnls
            // 
            btnls.Location = new Point(75, 325);
            btnls.Name = "btnls";
            btnls.Size = new Size(82, 86);
            btnls.TabIndex = 5;
            btnls.Text = "<<";
            btnls.UseVisualStyleBackColor = true;
            btnls.Click += btnls_Click;
            // 
            // btnrs
            // 
            btnrs.Location = new Point(193, 325);
            btnrs.Name = "btnrs";
            btnrs.Size = new Size(82, 86);
            btnrs.TabIndex = 6;
            btnrs.Text = ">>";
            btnrs.UseVisualStyleBackColor = true;
            btnrs.Click += btnrs_Click;
            // 
            // btnse
            // 
            btnse.Location = new Point(338, 325);
            btnse.Name = "btnse";
            btnse.Size = new Size(82, 86);
            btnse.TabIndex = 7;
            btnse.Text = "+=";
            btnse.UseVisualStyleBackColor = true;
            btnse.Click += btnse_Click;
            // 
            // btnme
            // 
            btnme.Location = new Point(456, 325);
            btnme.Name = "btnme";
            btnme.Size = new Size(82, 86);
            btnme.TabIndex = 8;
            btnme.Text = "-=";
            btnme.UseVisualStyleBackColor = true;
            btnme.Click += btnme_Click;
            // 
            // btnor
            // 
            btnor.Location = new Point(456, 445);
            btnor.Name = "btnor";
            btnor.Size = new Size(82, 86);
            btnor.TabIndex = 12;
            btnor.Text = "||";
            btnor.UseVisualStyleBackColor = true;
            btnor.Click += btnor_Click;
            // 
            // btnand
            // 
            btnand.Location = new Point(338, 445);
            btnand.Name = "btnand";
            btnand.Size = new Size(82, 86);
            btnand.TabIndex = 11;
            btnand.Text = "&&&&";
            btnand.UseVisualStyleBackColor = true;
            btnand.Click += btnand_Click;
            // 
            // btnpost
            // 
            btnpost.Location = new Point(193, 445);
            btnpost.Name = "btnpost";
            btnpost.Size = new Size(82, 86);
            btnpost.TabIndex = 10;
            btnpost.Text = "a++";
            btnpost.UseVisualStyleBackColor = true;
            btnpost.Click += btnpost_Click;
            // 
            // btnpre
            // 
            btnpre.Location = new Point(75, 445);
            btnpre.Name = "btnpre";
            btnpre.Size = new Size(82, 86);
            btnpre.TabIndex = 9;
            btnpre.Text = "++a";
            btnpre.UseVisualStyleBackColor = true;
            btnpre.Click += btnpre_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 675);
            Controls.Add(btnor);
            Controls.Add(btnand);
            Controls.Add(btnpost);
            Controls.Add(btnpre);
            Controls.Add(btnme);
            Controls.Add(btnse);
            Controls.Add(btnrs);
            Controls.Add(btnls);
            Controls.Add(tboxAo);
            Controls.Add(tboxNum);
            Controls.Add(tboxRstBit);
            Controls.Add(tboxRstAfter);
            Controls.Add(tboxRst);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxRst;
        private TextBox tboxRstAfter;
        private TextBox tboxRstBit;
        private TextBox tboxNum;
        private TextBox tboxAo;
        private Button btnls;
        private Button btnrs;
        private Button btnse;
        private Button btnme;
        private Button btnor;
        private Button btnand;
        private Button btnpost;
        private Button btnpre;
    }
}