namespace CHEXC
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpLoginName = new System.Windows.Forms.TextBox();
            this.txtEmpLoginPwd = new System.Windows.Forms.TextBox();
            this.txtEmpLoginConfPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEmpPost = new System.Windows.Forms.ComboBox();
            this.register = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "系统登录名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认密码：";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(266, 44);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(100, 21);
            this.txtEmpName.TabIndex = 4;
            // 
            // txtEmpLoginName
            // 
            this.txtEmpLoginName.Location = new System.Drawing.Point(266, 73);
            this.txtEmpLoginName.Name = "txtEmpLoginName";
            this.txtEmpLoginName.Size = new System.Drawing.Size(100, 21);
            this.txtEmpLoginName.TabIndex = 5;
            // 
            // txtEmpLoginPwd
            // 
            this.txtEmpLoginPwd.Location = new System.Drawing.Point(266, 100);
            this.txtEmpLoginPwd.Name = "txtEmpLoginPwd";
            this.txtEmpLoginPwd.Size = new System.Drawing.Size(100, 21);
            this.txtEmpLoginPwd.TabIndex = 6;
            // 
            // txtEmpLoginConfPwd
            // 
            this.txtEmpLoginConfPwd.Location = new System.Drawing.Point(266, 126);
            this.txtEmpLoginConfPwd.Name = "txtEmpLoginConfPwd";
            this.txtEmpLoginConfPwd.Size = new System.Drawing.Size(100, 21);
            this.txtEmpLoginConfPwd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "员工职位：";
            // 
            // cmbEmpPost
            // 
            this.cmbEmpPost.FormattingEnabled = true;
            this.cmbEmpPost.Items.AddRange(new object[] {
            "销售员",
            "进货员"});
            this.cmbEmpPost.Location = new System.Drawing.Point(266, 156);
            this.cmbEmpPost.Name = "cmbEmpPost";
            this.cmbEmpPost.Size = new System.Drawing.Size(100, 20);
            this.cmbEmpPost.TabIndex = 9;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(245, 198);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(59, 23);
            this.register.TabIndex = 10;
            this.register.Text = "确认";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "重置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(416, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.register);
            this.Controls.Add(this.cmbEmpPost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpLoginConfPwd);
            this.Controls.Add(this.txtEmpLoginPwd);
            this.Controls.Add(this.txtEmpLoginName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.Text = "员工注册";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpLoginName;
        private System.Windows.Forms.TextBox txtEmpLoginPwd;
        private System.Windows.Forms.TextBox txtEmpLoginConfPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEmpPost;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}