using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CHEXC.ClassInfo;
using CHEXC.GoodMenhod;

namespace CHEXC
{
    public partial class frmMyself : Form
    {
        public frmMyself()
        {
            InitializeComponent();
        }

        public frmMyself(string strName)
        {
            InitializeComponent();
            SendNameValue = strName;
            FillControls(SendNameValue);
        }
        public string SendNameValue;
        public string id;

        tb_EmpInfo EmpClass = new tb_EmpInfo();
        tb_EmpInfoMenthod tbMenthod = new tb_EmpInfoMenthod();

        private void button1_Click(object sender, EventArgs e)
        {
            EmpClass.intEmpId = id;
            EmpClass.strEmpName = txtEmpName.Text;
            EmpClass.strEmpLoginName = txtEmpLoginName.Text;
            EmpClass.strEmpLoginPwd = txtEmpLoginPwd.Text;
            EmpClass.intEmpSex = comboBox2.Text;
            EmpClass.daEmpBirthday = daEmpBirthday.Value;
            EmpClass.strEmpDept = cmbEmpDept.Text;
            EmpClass.strEmpPost = cmbEmpPost.Text;
            EmpClass.strEmpPhone = txtEmpPhone.Text;
            EmpClass.strEmpPhoneM = txtEmpPhoneM.Text;
            EmpClass.strEmpAddress = txtEmpAddress.Text;
            if (tbMenthod.tb_EmpInfoUpdate(EmpClass) == 1)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void FillControls(string s)
        {
            try
            {
                SqlDataReader sqldr = tbMenthod.tb_EmpInfoFind(s);
                //SqlDataReader sqldr = tbMenthod.tb_EmpInfoFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString(), 1);
                sqldr.Read();
                if (sqldr.HasRows)
                {
                    id = sqldr[0].ToString();
                    txtEmpLoginPwd.Text = sqldr[3].ToString();
                    txtEmpLoginName.Text = sqldr[2].ToString();
                    txtEmpName.Text = sqldr[1].ToString();
                    comboBox2.Text = sqldr[4].ToString();
                    daEmpBirthday.Value = Convert.ToDateTime(sqldr[5].ToString());
                    cmbEmpDept.Text = sqldr[6].ToString();
                    cmbEmpPost.Text = sqldr[7].ToString();
                    txtEmpPhone.Text = sqldr[8].ToString();
                    txtEmpPhoneM.Text = sqldr[9].ToString();
                    txtEmpAddress.Text = sqldr[10].ToString();
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }
        }
    }
}
