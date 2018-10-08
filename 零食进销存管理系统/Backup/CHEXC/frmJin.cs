using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHEXC
{
    public partial class frmJin : Form
    {
        public frmJin()
        {
            InitializeComponent();
        }

        public frmJin(string strName)
        {
            InitializeComponent();
            SendNameValue = strName;
        }
        public string SendNameValue;
        private void 商品进货ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //进贷信息
            frmJhGoodsInfo jhGOOD = new frmJhGoodsInfo();
            jhGOOD.Owner = this;
            jhGOOD.ShowDialog();
        }

        private void 进货管理CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuFind_Click(object sender, EventArgs e)
        {
            //商品信息查查询
            frmFindGood findgood = new frmFindGood();
            findgood.Owner = this;
            findgood.ShowDialog();
        }

        private void menuCompany_Click(object sender, EventArgs e)
        {
            //供应商信息
            frmCompanyInfo frmComp = new frmCompanyInfo();
            frmComp.Owner = this;
            frmComp.ShowDialog();
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            //员工信息
            /*frmEmpInfo empinfo = new frmEmpInfo();
            empinfo.Owner = this;
            empinfo.ShowDialog();*/
            frmMyself myself = new frmMyself(SendNameValue);
            //frmMyself.SendNameValue = SendNameValue;
            myself.Owner = this;
            myself.ShowDialog();
        }

        private void menuBaseManage_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frl = new frmLogin();
            frl.Show();
            this.Hide();
        }
    }
}
