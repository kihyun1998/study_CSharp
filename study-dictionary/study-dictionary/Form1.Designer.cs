﻿
namespace study_dictionary
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tBoxModify = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tBoxGet = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.tBoxOld = new System.Windows.Forms.TextBox();
            this.tBoxNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show 하나씩";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show 전부";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tBoxModify
            // 
            this.tBoxModify.Location = new System.Drawing.Point(336, 25);
            this.tBoxModify.Name = "tBoxModify";
            this.tBoxModify.Size = new System.Drawing.Size(223, 25);
            this.tBoxModify.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(452, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Modify";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(452, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 36);
            this.button5.TabIndex = 6;
            this.button5.Text = "Get Value";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tBoxGet
            // 
            this.tBoxGet.Location = new System.Drawing.Point(336, 134);
            this.tBoxGet.Name = "tBoxGet";
            this.tBoxGet.Size = new System.Drawing.Size(223, 25);
            this.tBoxGet.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(452, 301);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 36);
            this.button6.TabIndex = 8;
            this.button6.Text = "Change Key";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // tBoxOld
            // 
            this.tBoxOld.Location = new System.Drawing.Point(395, 239);
            this.tBoxOld.Name = "tBoxOld";
            this.tBoxOld.Size = new System.Drawing.Size(164, 25);
            this.tBoxOld.TabIndex = 7;
            // 
            // tBoxNew
            // 
            this.tBoxNew.Location = new System.Drawing.Point(395, 270);
            this.tBoxNew.Name = "tBoxNew";
            this.tBoxNew.Size = new System.Drawing.Size(164, 25);
            this.tBoxNew.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "old";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "new";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(39, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 30);
            this.button7.TabIndex = 12;
            this.button7.Text = "초기화";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 392);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxNew);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tBoxOld);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tBoxGet);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tBoxModify);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tBoxModify;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tBoxGet;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tBoxOld;
        private System.Windows.Forms.TextBox tBoxNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
    }
}

