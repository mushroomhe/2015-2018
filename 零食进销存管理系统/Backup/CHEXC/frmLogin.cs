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
                a = "����Ա";
            }
            if (radioButton2.Checked == true)
            {
                a = "����Ա";
            }
            if (radioButton3.Checked == true)
            {
                a = "����Ա";
            }
            if (txtID.Text == "")
            {
                MessageBox.Show("�û�������Ϊ�գ�");
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("���벻��Ϊ�գ�");
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked==false)
            {
                MessageBox.Show("��ѡ���û���ɫ��");
                return;
            }
            if (tbEmp.tb_EmpInfoFind(txtID.Text, txtPwd.Text,a, 2) == 1)
            {
                if (a == "����Ա")
                {
                    frmShou frs = new frmShou(txtID.Text);
                    frs.Show();
                    this.Hide();
                }
                else if (a == "����Ա")
                {
                    frmJin frj = new frmJin(txtID.Text);
                    frj.Show();
                    this.Hide();
                }
                else if(a=="����Ա")
                {
                    frmMain frm = new frmMain(txtID.Text);
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("��¼ʧ�ܣ�");
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