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
    public partial class frmJhGoodsInfo : Form
    {
        public frmJhGoodsInfo()
        {
            InitializeComponent();
        }
        public frmJhGoodsInfo(int intCdo)
        {
            InitializeComponent();
        }

        tb_JhGoodsInfo jhGood=new tb_JhGoodsInfo();
        tb_JhGoodsInfoMenthod jhMenthod=new tb_JhGoodsInfoMenthod();
        public static int intFalg = 0;
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.tollDelete.Enabled = !this.tollDelete.Enabled;
        }
        public void ClearContorl()
        {
            txtGoodsNum.Text = "";
            txtGoodsRemark.Text = "";
            txtGoodsSellPrice.Text = "";
            txtJhCompName.Text = "";
            txtGoodsNoPrice.Text = "";
            txtGoodsNeedPrice.Text = "";
            txtGoodsName.Text = "";
            txtGoodsJhPrice.Text = "";
            txtGoodsID.Text = "";
            txtEmpId.Text = "";
            cmbDepotName.Text = "";
        }
        public int getIntCount()
        {
            return 0;
        }
        private void frmJhGoodsInfo_Load(object sender, EventArgs e)
        {
            jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
        }
        private void FillControls()
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
            intFalg = 1;//添加标记
            txtGoodsID.Text = jhMenthod.JhGoodsID();
             txtGoodsID.Enabled = false;
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
            intFalg = 2;//添加标记
        }

        private void toolrefulsh_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
    

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();


        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void txtGoodsJhPrice_TextChanged(object sender, EventArgs e)
        {
           

        }


        private void txtGoodsSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            
         
        }

        private void txtGoodsJhPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
    

        }

        private void txtGoodsNoPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        //供应商信息
        private void button1_Click(object sender, EventArgs e)
        {
            frmGonYingShang frmgong = new frmGonYingShang();
            frmgong.Owner = this;
            frmgong.ShowDialog();
        }


        private void tollDelete_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
            intFalg = 3;//添加标记
        }

   

 
    }
}