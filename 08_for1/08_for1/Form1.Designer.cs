namespace _08_for1
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
            tBoxRst = new TextBox();
            btnFor = new Button();
            bntForEach = new Button();
            SuspendLayout();
            // 
            // tBoxRst
            // 
            tBoxRst.Location = new Point(25, 23);
            tBoxRst.Multiline = true;
            tBoxRst.Name = "tBoxRst";
            tBoxRst.ScrollBars = ScrollBars.Vertical;
            tBoxRst.Size = new Size(554, 558);
            tBoxRst.TabIndex = 0;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(664, 95);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(150, 46);
            btnFor.TabIndex = 1;
            btnFor.Text = "for 문";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // bntForEach
            // 
            bntForEach.Location = new Point(664, 346);
            bntForEach.Name = "bntForEach";
            bntForEach.Size = new Size(150, 46);
            bntForEach.TabIndex = 2;
            bntForEach.Text = "foreach문";
            bntForEach.UseVisualStyleBackColor = true;
            bntForEach.Click += bntForEach_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 608);
            Controls.Add(bntForEach);
            Controls.Add(btnFor);
            Controls.Add(tBoxRst);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxRst;
        private Button btnFor;
        private Button bntForEach;
    }
}