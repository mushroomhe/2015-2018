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
    public partial class frmEmpInfo : Form
    {
        public frmEmpInfo()
        {
            InitializeComponent();
        }
        tb_EmpInfo EmpClass = new tb_EmpInfo();
        tb_EmpInfoMenthod tbMenthod = new tb_EmpInfoMenthod();
        public static int intFalg = 0;//控件方法状态
        int G_Int_status;  //保存工具栏按钮操作状态
        public int getPan()
        {
            return 0;
        
        }
        /// <summary>
        /// 控制控件状态
        /// </summary>
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.toolDelete.Enabled = !this.toolDelete.Enabled;
        }

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls()
        {

            txtEmpAddress.Text = "";
            txtEmpLoginName.Text = "";
            txtEmpLoginPwd.Text = "";
            txtEmpName.Text = "";
            txtEmpPhone.Text = "";
            txtEmpPhoneM.Text = "";
            cmbEmpDept.SelectedIndex = 0;
            cmbEmpPost.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            this.daEmpBirthday.Value = DateTime.Now;
        }

        private void frmEmpInfo_Load(object sender, EventArgs e)
        {
            tbMenthod.tb_EmpInfoFind("",5,dataGridView1);
      
        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ClearControls();//清空控件内容
            ControlStatus();//控件控年状态
            intFalg = 1;//添加标
        }
   

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intFalg = 2;//修改标记

        }

        private void toolrefesh_Click(object sender, EventArgs e)
        {
            ClearControls();//刷新
            ControlStatus();
        }

        //查询
        private void txtOK_Click(object sender, EventArgs e)
        {

        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            ControlStatus();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            

        }
        private void FillControls()
        {
            try
            {
                SqlDataReader sqldr = tbMenthod.tb_EmpInfoFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString(),1);
                sqldr.Read();
                if (sqldr.HasRows)
                {
                    txtEmpLoginName.Text = sqldr[2].ToString();
                    txtEmpName.Text = sqldr[1].ToString();
                    comboBox2.Text =sqldr[4].ToString();
                    daEmpBirthday.Value = Convert.ToDateTime(sqldr[5].ToString());
                    cmbEmpDept.Text =sqldr[6].ToString();
                    cmbEmpPost.Text = sqldr[7].ToString();
                    txtEmpPhone.Text = sqldr[8].ToString();
                    txtEmpPhoneM.Text = sqldr[9].ToString();
                    txtEmpAddress.Text = sqldr[10].ToString();

                
                }


            }
            catch(Exception ee) 
            {
                MessageBox.Show(ee.ToString());
            
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
      
            ControlStatus();//控件控年状态
            intFalg = 3;//删除标记
        }


    }
}