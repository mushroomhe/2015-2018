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
    public partial class frmCompanyInfo : Form
    {
        public frmCompanyInfo()
        {
            InitializeComponent();
        }
        public frmCompanyInfo(int intResult)
        {
            InitializeComponent();
            intReturn = intResult;
        }
        public static int intReturn = 0;
        tb_Company Company = new tb_Company();
        tb_CompanyMenthod CompanyMenthod = new tb_CompanyMenthod();
        tb_JhGoodsInfoMenthod jhgood = new tb_JhGoodsInfoMenthod();
        public static int intFalg =0;
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.toolrefesh.Enabled = !this.toolrefesh.Enabled;
        }

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {

            txtCompanyDirector.Text = "";
            txtCompanyAddress.Text = "";
            txtCompanyFax.Text = "";
            txtCompanyName.Text = "";
            txtCompanyPhone.Text = "";
            txtCompanyRemark.Text = "";
           
        }

        /// 控制控件状态
        /// </summary>

        public int GetCount()
        {

            int intReslult=1;
            return intReslult;
        
        }

        private void frmCompanyInfo_Load(object sender, EventArgs e)
        {
            CompanyMenthod.tb_CompanyFind("", 3, dataGridView1);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
           
        }
        private void FillControls()
        {
            
   
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
           ClearControls();
           ControlStatus();
            intFalg = 0;
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            intFalg = 1;//添加标记
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearControls();
            intFalg = 2;//修改加标记
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {

        }

        private void txtOK_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolrefesh_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intFalg = 3;//修改加标记
        }
    }
}