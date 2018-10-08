using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CHEXC.GoodMenhod;
namespace CHEXC
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            tb_EmpInfoMenthod tbEmp = new tb_EmpInfoMenthod();
            frmMain frm = new frmMain(txtID.Text);
            frm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tb_EmpInfoMenthod tbEmp = new tb_EmpInfoMenthod();
            string a = "";
            if (radioButton1.Checked == true)
            {
                a = "销售员";
            }
            if (radioButton2.Checked == true)
            {
                a = "进货员";
            }
            if (radioButton3.Checked == true)
            {
                a = "管理员";
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked==false)
            {
                MessageBox.Show("请选择用户角色！");
                return;
            }
            if (tbEmp.tb_EmpInfoFind(txtID.Text, txtPwd.Text,a, 2) == 1)
            {
                if (a == "销售员")
                {
                    frmShou frs = new frmShou(txtID.Text);
                    frs.Show();
                    this.Hide();
                }
                else if (a == "进货员")
                {
                    frmJin frj = new frmJin(txtID.Text);
                    frj.Show();
                    this.Hide();
                }
                else if(a=="管理员")
                {
                    frmMain frm = new frmMain(txtID.Text);
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRegister frr = new frmRegister();
            frr.Show();
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}