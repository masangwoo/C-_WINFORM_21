
namespace ApplicationDev
{
    partial class FM_passWord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_changepw = new System.Windows.Forms.Label();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.txt_prePW = new System.Windows.Forms.TextBox();
            this.txt_changPw = new System.Windows.Forms.TextBox();
            this.btn_chpw = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "사용자ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "이전 PW";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_changepw
            // 
            this.txt_changepw.AutoSize = true;
            this.txt_changepw.Location = new System.Drawing.Point(67, 213);
            this.txt_changepw.Name = "txt_changepw";
            this.txt_changepw.Size = new System.Drawing.Size(67, 20);
            this.txt_changepw.TabIndex = 2;
            this.txt_changepw.Text = "변경 PW";
            this.txt_changepw.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(195, 67);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(350, 27);
            this.txt_userid.TabIndex = 3;
            // 
            // txt_prePW
            // 
            this.txt_prePW.Location = new System.Drawing.Point(195, 138);
            this.txt_prePW.Name = "txt_prePW";
            this.txt_prePW.Size = new System.Drawing.Size(350, 27);
            this.txt_prePW.TabIndex = 4;
            this.txt_prePW.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_changPw
            // 
            this.txt_changPw.Location = new System.Drawing.Point(195, 210);
            this.txt_changPw.Name = "txt_changPw";
            this.txt_changPw.Size = new System.Drawing.Size(350, 27);
            this.txt_changPw.TabIndex = 5;
            // 
            // btn_chpw
            // 
            this.btn_chpw.Location = new System.Drawing.Point(324, 277);
            this.btn_chpw.Name = "btn_chpw";
            this.btn_chpw.Size = new System.Drawing.Size(94, 29);
            this.btn_chpw.TabIndex = 6;
            this.btn_chpw.Text = "변경";
            this.btn_chpw.UseVisualStyleBackColor = true;
            this.btn_chpw.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(451, 277);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(94, 29);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // FM_passWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 385);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_chpw);
            this.Controls.Add(this.txt_changPw);
            this.Controls.Add(this.txt_prePW);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.txt_changepw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FM_passWord";
            this.Text = "비밀번호 변경";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_changepw;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.TextBox txt_prePW;
        private System.Windows.Forms.TextBox txt_changPw;
        private System.Windows.Forms.Button btn_chpw;
        private System.Windows.Forms.Button btn_close;
    }
}