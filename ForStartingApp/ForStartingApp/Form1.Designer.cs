
namespace ForStartingApp
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
            this.btnPutty = new System.Windows.Forms.Button();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.tBoxPw = new System.Windows.Forms.TextBox();
            this.tBoxIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilezilla = new System.Windows.Forms.Button();
            this.btnMobaXterm = new System.Windows.Forms.Button();
            this.btnMobaxPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxMobaxPath = new System.Windows.Forms.TextBox();
            this.tBoxZillaPath = new System.Windows.Forms.TextBox();
            this.tBoxPuttyPath = new System.Windows.Forms.TextBox();
            this.btnPuttyPath = new System.Windows.Forms.Button();
            this.btnZillaPath = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPutty
            // 
            this.btnPutty.Location = new System.Drawing.Point(574, 69);
            this.btnPutty.Name = "btnPutty";
            this.btnPutty.Size = new System.Drawing.Size(168, 104);
            this.btnPutty.TabIndex = 0;
            this.btnPutty.Text = "Putty";
            this.btnPutty.UseVisualStyleBackColor = true;
            this.btnPutty.Click += new System.EventHandler(this.btnPutty_Click);
            // 
            // tBoxId
            // 
            this.tBoxId.Location = new System.Drawing.Point(116, 55);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.Size = new System.Drawing.Size(321, 25);
            this.tBoxId.TabIndex = 1;
            // 
            // tBoxPw
            // 
            this.tBoxPw.Location = new System.Drawing.Point(116, 99);
            this.tBoxPw.Name = "tBoxPw";
            this.tBoxPw.PasswordChar = '*';
            this.tBoxPw.Size = new System.Drawing.Size(321, 25);
            this.tBoxPw.TabIndex = 2;
            // 
            // tBoxIp
            // 
            this.tBoxIp.Location = new System.Drawing.Point(116, 148);
            this.tBoxIp.Name = "tBoxIp";
            this.tBoxIp.Size = new System.Drawing.Size(321, 25);
            this.tBoxIp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP주소";
            // 
            // btnFilezilla
            // 
            this.btnFilezilla.Location = new System.Drawing.Point(574, 179);
            this.btnFilezilla.Name = "btnFilezilla";
            this.btnFilezilla.Size = new System.Drawing.Size(168, 104);
            this.btnFilezilla.TabIndex = 8;
            this.btnFilezilla.Text = "FileZilla";
            this.btnFilezilla.UseVisualStyleBackColor = true;
            this.btnFilezilla.Click += new System.EventHandler(this.btnFilezilla_Click);
            // 
            // btnMobaXterm
            // 
            this.btnMobaXterm.Location = new System.Drawing.Point(574, 289);
            this.btnMobaXterm.Name = "btnMobaXterm";
            this.btnMobaXterm.Size = new System.Drawing.Size(168, 104);
            this.btnMobaXterm.TabIndex = 9;
            this.btnMobaXterm.Text = "MobaXterm";
            this.btnMobaXterm.UseVisualStyleBackColor = true;
            this.btnMobaXterm.Click += new System.EventHandler(this.btnMobaXterm_Click);
            // 
            // btnMobaxPath
            // 
            this.btnMobaxPath.Location = new System.Drawing.Point(316, 143);
            this.btnMobaxPath.Name = "btnMobaxPath";
            this.btnMobaxPath.Size = new System.Drawing.Size(70, 28);
            this.btnMobaxPath.TabIndex = 12;
            this.btnMobaxPath.Text = "설정";
            this.btnMobaxPath.UseVisualStyleBackColor = true;
            this.btnMobaxPath.Click += new System.EventHandler(this.btnMobaxPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBoxMobaxPath);
            this.groupBox1.Controls.Add(this.tBoxZillaPath);
            this.groupBox1.Controls.Add(this.tBoxPuttyPath);
            this.groupBox1.Controls.Add(this.btnPuttyPath);
            this.groupBox1.Controls.Add(this.btnZillaPath);
            this.groupBox1.Controls.Add(this.btnMobaxPath);
            this.groupBox1.Location = new System.Drawing.Point(33, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 198);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "MobaXterm 경로";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "FileZilla 경로";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Putty 경로";
            // 
            // tBoxMobaxPath
            // 
            this.tBoxMobaxPath.Location = new System.Drawing.Point(126, 143);
            this.tBoxMobaxPath.Name = "tBoxMobaxPath";
            this.tBoxMobaxPath.Size = new System.Drawing.Size(158, 25);
            this.tBoxMobaxPath.TabIndex = 17;
            // 
            // tBoxZillaPath
            // 
            this.tBoxZillaPath.Location = new System.Drawing.Point(126, 97);
            this.tBoxZillaPath.Name = "tBoxZillaPath";
            this.tBoxZillaPath.Size = new System.Drawing.Size(158, 25);
            this.tBoxZillaPath.TabIndex = 16;
            // 
            // tBoxPuttyPath
            // 
            this.tBoxPuttyPath.Location = new System.Drawing.Point(126, 47);
            this.tBoxPuttyPath.Name = "tBoxPuttyPath";
            this.tBoxPuttyPath.Size = new System.Drawing.Size(158, 25);
            this.tBoxPuttyPath.TabIndex = 15;
            // 
            // btnPuttyPath
            // 
            this.btnPuttyPath.Location = new System.Drawing.Point(316, 47);
            this.btnPuttyPath.Name = "btnPuttyPath";
            this.btnPuttyPath.Size = new System.Drawing.Size(70, 25);
            this.btnPuttyPath.TabIndex = 14;
            this.btnPuttyPath.Text = "설정";
            this.btnPuttyPath.UseVisualStyleBackColor = true;
            this.btnPuttyPath.Click += new System.EventHandler(this.btnPuttyPath_Click_Click);
            // 
            // btnZillaPath
            // 
            this.btnZillaPath.Location = new System.Drawing.Point(316, 97);
            this.btnZillaPath.Name = "btnZillaPath";
            this.btnZillaPath.Size = new System.Drawing.Size(70, 25);
            this.btnZillaPath.TabIndex = 13;
            this.btnZillaPath.Text = "설정";
            this.btnZillaPath.UseVisualStyleBackColor = true;
            this.btnZillaPath.Click += new System.EventHandler(this.btnZillaPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMobaXterm);
            this.Controls.Add(this.btnFilezilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxIp);
            this.Controls.Add(this.tBoxPw);
            this.Controls.Add(this.tBoxId);
            this.Controls.Add(this.btnPutty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPutty;
        private System.Windows.Forms.TextBox tBoxId;
        private System.Windows.Forms.TextBox tBoxPw;
        private System.Windows.Forms.TextBox tBoxIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilezilla;
        private System.Windows.Forms.Button btnMobaXterm;
        private System.Windows.Forms.Button btnMobaxPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxMobaxPath;
        private System.Windows.Forms.TextBox tBoxZillaPath;
        private System.Windows.Forms.TextBox tBoxPuttyPath;
        private System.Windows.Forms.Button btnPuttyPath;
        private System.Windows.Forms.Button btnZillaPath;
    }
}

