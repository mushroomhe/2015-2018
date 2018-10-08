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
    public partial class frmKcGoods : Form
    {
        public frmKcGoods()
        {
            InitializeComponent();
        }

        tb_KcGoods kcGood = new tb_KcGoods();
        tb_KcGoodsMenthod tb_GoodMenthd = new tb_KcGoodsMenthod();
        private void frmKcGoods_Load(object sender, EventArgs e)
        {
            
        }
        private void FillControls()
        {
           
        }
        public void ClearFill()
        {
            txtid.Text ="";
            txtGoodsName.Text = "";
            txtGoodsJhPrice.Text = "";
            txtGoodsSellPrice.Text = "";
            txtGoodsNum.Text = "";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("«Î ‰»Î ˝◊÷");
                e.Handled = true;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}