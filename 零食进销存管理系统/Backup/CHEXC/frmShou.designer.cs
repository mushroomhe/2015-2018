namespace CHEXC
{
    partial class frmShou
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShou));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSellManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSellGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSellFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSellManage,
            this.menuBaseManage,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(727, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSellManage
            // 
            this.menuSellManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSellGoods,
            this.menuSellFind});
            this.menuSellManage.Name = "menuSellManage";
            this.menuSellManage.Size = new System.Drawing.Size(83, 21);
            this.menuSellManage.Text = "销售管理[&S]";
            // 
            // menuSellGoods
            // 
            this.menuSellGoods.Name = "menuSellGoods";
            this.menuSellGoods.Size = new System.Drawing.Size(142, 22);
            this.menuSellGoods.Text = "商品销售[&G]";
            this.menuSellGoods.Click += new System.EventHandler(this.menuSellGoods_Click);
            // 
            // menuSellFind
            // 
            this.menuSellFind.Name = "menuSellFind";
            this.menuSellFind.Size = new System.Drawing.Size(142, 22);
            this.menuSellFind.Text = "商品退货[&O]";
            this.menuSellFind.Click += new System.EventHandler(this.menuSellFind_Click);
            // 
            // menuBaseManage
            // 
            this.menuBaseManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployee});
            this.menuBaseManage.Name = "menuBaseManage";
            this.menuBaseManage.Size = new System.Drawing.Size(84, 21);
            this.menuBaseManage.Text = "基本档案[&B]";
            this.menuBaseManage.Click += new System.EventHandler(this.menuEmployee_Click);
            // 
            // menuEmployee
            // 
            this.menuEmployee.Name = "menuEmployee";
            this.menuEmployee.Size = new System.Drawing.Size(152, 22);
            this.menuEmployee.Text = "个人信息[&E]";
            this.menuEmployee.Click += new System.EventHandler(this.menuEmployee_Click_1);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统[&D]";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // frmShou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 556);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmShou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "零食进销存管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSellManage;
        private System.Windows.Forms.ToolStripMenuItem menuSellGoods;
        private System.Windows.Forms.ToolStripMenuItem menuSellFind;
        private System.Windows.Forms.ToolStripMenuItem menuBaseManage;
        private System.Windows.Forms.ToolStripMenuItem menuEmployee;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}