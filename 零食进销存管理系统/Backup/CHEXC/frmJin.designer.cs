namespace CHEXC
{
    partial class frmJin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStockManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGoodsIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStockManage,
            this.menuBaseManage,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(671, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuStockManage
            // 
            this.menuStockManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGoodsIn,
            this.menuFind});
            this.menuStockManage.Name = "menuStockManage";
            this.menuStockManage.Size = new System.Drawing.Size(84, 21);
            this.menuStockManage.Text = "进货管理[&C]";
            this.menuStockManage.Click += new System.EventHandler(this.进货管理CToolStripMenuItem_Click);
            // 
            // menuGoodsIn
            // 
            this.menuGoodsIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.menuGoodsIn.Name = "menuGoodsIn";
            this.menuGoodsIn.Size = new System.Drawing.Size(138, 22);
            this.menuGoodsIn.Text = "商品进货[&S]";
            this.menuGoodsIn.Click += new System.EventHandler(this.商品进货ToolStripMenuItem_Click);
            // 
            // menuFind
            // 
            this.menuFind.Name = "menuFind";
            this.menuFind.Size = new System.Drawing.Size(138, 22);
            this.menuFind.Text = "商品查询[&F]";
            this.menuFind.Click += new System.EventHandler(this.menuFind_Click);
            // 
            // menuBaseManage
            // 
            this.menuBaseManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployee});
            this.menuBaseManage.Name = "menuBaseManage";
            this.menuBaseManage.Size = new System.Drawing.Size(84, 21);
            this.menuBaseManage.Text = "基本档案[&B]";
            this.menuBaseManage.Click += new System.EventHandler(this.menuBaseManage_Click);
            // 
            // menuEmployee
            // 
            this.menuEmployee.Name = "menuEmployee";
            this.menuEmployee.Size = new System.Drawing.Size(152, 22);
            this.menuEmployee.Text = "员工信息[&E]";
            this.menuEmployee.Click += new System.EventHandler(this.menuEmployee_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统[&D]";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // frmJin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(671, 502);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmJin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "零食进销存管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStockManage;
        private System.Windows.Forms.ToolStripMenuItem menuGoodsIn;
        private System.Windows.Forms.ToolStripMenuItem menuFind;
        private System.Windows.Forms.ToolStripMenuItem menuBaseManage;
        private System.Windows.Forms.ToolStripMenuItem menuEmployee;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
    }
}