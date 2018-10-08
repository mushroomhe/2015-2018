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
        public static int intFalg = 0;//�ؼ�����״̬
        int G_Int_status;  //���湤������ť����״̬
        public int getPan()
        {
            return 0;
        
        }
        /// <summary>
        /// ���ƿؼ�״̬
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
        /// ���ؼ��ָ���ԭʼ״̬
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
            ClearControls();//��տؼ�����
            ControlStatus();//�ؼ�����״̬
            intFalg = 1;//��ӱ�
        }
   

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            intFalg = 2;//�޸ı��

        }

        private void toolrefesh_Click(object sender, EventArgs e)
        {
            ClearControls();//ˢ��
            ControlStatus();
        }

        //��ѯ
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
      
            ControlStatus();//�ؼ�����״̬
            intFalg = 3;//ɾ�����
        }


    }
}