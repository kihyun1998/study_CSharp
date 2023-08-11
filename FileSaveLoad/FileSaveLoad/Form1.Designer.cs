
namespace FileSaveLoad
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
            this.tBoxUrl = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tBoxLoad = new System.Windows.Forms.TextBox();
            this.tBoxCookie = new System.Windows.Forms.TextBox();
            this.tBoxMsg = new System.Windows.Forms.TextBox();
            this.cBoxMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tBoxUrl
            // 
            this.tBoxUrl.Location = new System.Drawing.Point(40, 58);
            this.tBoxUrl.Name = "tBoxUrl";
            this.tBoxUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxUrl.Size = new System.Drawing.Size(601, 25);
            this.tBoxUrl.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(233, 64);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(475, 226);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(233, 64);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tBoxLoad
            // 
            this.tBoxLoad.Location = new System.Drawing.Point(87, 323);
            this.tBoxLoad.Multiline = true;
            this.tBoxLoad.Name = "tBoxLoad";
            this.tBoxLoad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxLoad.Size = new System.Drawing.Size(601, 69);
            this.tBoxLoad.TabIndex = 3;
            // 
            // tBoxCookie
            // 
            this.tBoxCookie.Location = new System.Drawing.Point(40, 89);
            this.tBoxCookie.Name = "tBoxCookie";
            this.tBoxCookie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxCookie.Size = new System.Drawing.Size(601, 25);
            this.tBoxCookie.TabIndex = 4;
            // 
            // tBoxMsg
            // 
            this.tBoxMsg.Location = new System.Drawing.Point(40, 120);
            this.tBoxMsg.Name = "tBoxMsg";
            this.tBoxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxMsg.Size = new System.Drawing.Size(601, 25);
            this.tBoxMsg.TabIndex = 5;
            // 
            // cBoxMethod
            // 
            this.cBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoxMethod.FormattingEnabled = true;
            this.cBoxMethod.Location = new System.Drawing.Point(660, 58);
            this.cBoxMethod.Name = "cBoxMethod";
            this.cBoxMethod.Size = new System.Drawing.Size(128, 23);
            this.cBoxMethod.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBoxMethod);
            this.Controls.Add(this.tBoxMsg);
            this.Controls.Add(this.tBoxCookie);
            this.Controls.Add(this.tBoxLoad);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBoxUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tBoxLoad;
        private System.Windows.Forms.TextBox tBoxCookie;
        private System.Windows.Forms.TextBox tBoxMsg;
        private System.Windows.Forms.ComboBox cBoxMethod;
    }
}

