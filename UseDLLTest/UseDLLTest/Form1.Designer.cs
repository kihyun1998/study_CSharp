
namespace UseDLLTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxStr = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tBoxByte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBoxStr
            // 
            this.tBoxStr.Location = new System.Drawing.Point(23, 12);
            this.tBoxStr.Name = "tBoxStr";
            this.tBoxStr.Size = new System.Drawing.Size(345, 25);
            this.tBoxStr.TabIndex = 0;
            this.tBoxStr.TextChanged += new System.EventHandler(this.tBoxStr_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(113, 177);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(164, 55);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "확인";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tBoxByte
            // 
            this.tBoxByte.Location = new System.Drawing.Point(23, 52);
            this.tBoxByte.Multiline = true;
            this.tBoxByte.Name = "tBoxByte";
            this.tBoxByte.ReadOnly = true;
            this.tBoxByte.Size = new System.Drawing.Size(345, 119);
            this.tBoxByte.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 235);
            this.Controls.Add(this.tBoxByte);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tBoxStr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxStr;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox tBoxByte;
    }
}

