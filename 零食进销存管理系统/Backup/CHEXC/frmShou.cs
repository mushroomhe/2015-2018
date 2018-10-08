using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHEXC
{
    public partial class frmShou : Form
    {
        public frmShou()
        {
            InitializeComponent();
        }
        public frmShou(string strName)
        {
            InitializeComponent();
            SendNameValue = strName;
        }
        public string SendNameValue;

        private void menuSellGoods_Click(object sender, EventArgs e)
        {
            //商品销售信息
            frmSellGoods frmSell = new frmSellGoods();
            frmSell.Owner = this;
            frmSell.ShowDialog();
        }

        private void menuSellFind_Click(object sender, EventArgs e)
        {
            //退货信息
            frmThGoodsInfo frmTh = new frmThGoodsInfo();
            frmTh.Owner = this;
            frmTh.ShowDialog();
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            
        }

        private void menuEmployee_Click_1(object sender, EventArgs e)
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
        /*private void frmMain_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            this.statusUser.Text = "系统操作员：" + SendNameValue;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            this.statusTime.Text = "当前时间：" + DateTime.Now.ToString();
        }*/

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frl = new frmLogin();
            frl.Show();
            this.Hide();
        }
    }
}
