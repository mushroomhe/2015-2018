using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHEXC.ClassInfo;
using CHEXC.GoodMenhod;
using System.Data.SqlClient;
namespace CHEXC
{
    public partial class frmThGoodsInfo : Form
    {
        public frmThGoodsInfo()
        {
            InitializeComponent();
        }

        tb_ThGoodsInfo tbGoodinfo = new tb_ThGoodsInfo();
        tb_ThGoodsMenthod tbMendd = new tb_ThGoodsMenthod();
        public string goodid = null;
        public string Kcid = null;
        public int intCoun = 0;
        public void getClear()
        {

           txtThGoodsID.Text="";
             txtSellID.Text="";
             txtSellID.Text="";
            txtThGoodsName.Text="";
            txThGoodsNum.Text="";
            daThGoodsTime.Value = DateTime.Now; 
            txtThGoodsPrice.Text="";
            txtThHasPay.Text="";
             txtThNeedPay.Text="";
            txtThGoodsResult.Text="";
            txtDataTime.Text = "";
            txtPrice.Text = "";
            txtnum.Text = "";
            txtEmpID.Text = "";
        
        }


        public int retuCount()
        {
            int intResult = 0;
            return intResult=1;
         
        
        }

        private void frmThGoodsInfo_Load(object sender, EventArgs e)
        {
            tbMendd.tb_ThGoodsFind(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSellGoodInfo frmSell = new frmSellGoodInfo();
            frmSell.Owner = this;
            frmSell.ShowDialog();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (intCoun == 2 || intCoun == 3)
                {
                    FillControls();
                    fillGet();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message.ToString());
            }
        }
        public void FillControls()
        {
           
        
        }
        public void fillGet()
        {
            
            
            
           
        }
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.toolDelete.Enabled = !toolDelete.Enabled;

        }
        //保存
        private void toolSave_Click(object sender, EventArgs e)
        {
            
        }
        //取消
        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStatus();
            getClear();
        }
        //添加
        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            getClear();
            txtThGoodsID.Text = tbMendd.tb_ThGoodsID();
            intCoun = 1;//i添加标记

        }
        //修改
        private void toolAmend_Click(object sender, EventArgs e)
        {

            ControlStatus();
            getClear();
            intCoun = 2;//i修改标记
        }
        //退出
        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txThGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }

        private void txtThGoodsPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)&&e.KeyChar!='.')
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }

        private void txtThNeedPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }

        private void txtThHasPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("输入数字");
                e.Handled = true;
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intCoun = 3;//i修改标记
        }
    }
}