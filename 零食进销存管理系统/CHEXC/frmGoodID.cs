using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHEXC.GoodMenhod;
using CHEXC.ClassInfo;
namespace CHEXC
{
    public partial class frmGoodID : Form
    {
        public frmGoodID()
        {
            InitializeComponent();
        }

        tb_SellGoodsMenthod tbsell = new tb_SellGoodsMenthod();
        private void frmGoodID_Load(object sender, EventArgs e)
        {
            tbsell.filltProd(treeView1,imageList1);

        }
        //添加商品信息
        private void button1_Click(object sender, EventArgs e)
        {
            frmJhGoodsInfo JhGoods = new frmJhGoodsInfo(1);
            JhGoods.Owner = this;
            JhGoods.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}