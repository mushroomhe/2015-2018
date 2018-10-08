using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHEXC.ClassInfo;
using CHEXC.GoodMenhod;

namespace CHEXC
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        tb_EmpInfo EmpClass = new tb_EmpInfo();
        tb_EmpInfoMenthod tbMenthod = new tb_EmpInfoMenthod();
        //public static int intFalg = 1;//控件方法状态
    
        public int getPan()
        {
            int intFalg1 = 0;

            
                if (txtEmpName.Text == "") {
                    MessageBox.Show("员工姓名不能为空！","提示");
                    txtEmpName.Focus();
                    return intFalg1;
                }
                if (txtEmpLoginName.Text == "") {
                    MessageBox.Show("登录名称不能为空！","提示");
                    return intFalg1;
                }
                if (txtEmpLoginPwd.Text != txtEmpLoginConfPwd.Text)
                {
                    MessageBox.Show("两次密码不一致！","提示");
                    return intFalg1;
                }

                
                    if (txtEmpLoginPwd.Text == "") {
                        MessageBox.Show("登录密码不能为空！", "提示");
                        return intFalg1;
                    
                }
            EmpClass.intEmpId = tbMenthod.tb_EmpInfoID();
            EmpClass.strEmpName = txtEmpName.Text;
            EmpClass.strEmpLoginName = txtEmpLoginName.Text;
            EmpClass.strEmpLoginPwd = txtEmpLoginPwd.Text;
            EmpClass.strEmpPost = cmbEmpPost.Text;
            /*if (intFalg != 3)
            {
                EmpClass.intEmpFalg = 0;
            }
            else
            {
                EmpClass.intEmpFalg = 1;
            }*/
            intFalg1 = 1;
            return intFalg1;
        }

        /// <summary>
        /// 将控件恢复到原始状态
        /// </summary>
        private void ClearControls() {
            txtEmpLoginName.Text = "";
            txtEmpLoginPwd.Text = "";
            txtEmpName.Text = "";
            txtEmpLoginConfPwd.Text = "";
            cmbEmpPost.SelectedIndex = 0;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (getPan() == 1) {
                
                    if (tbMenthod.tb_EmpInfoFind(txtEmpLoginName.Text ,"","", 1) == 1) {
                        MessageBox.Show("登录名称已被占用!！");
                        txtEmpLoginName.Text = "";
                        txtEmpLoginName.Focus();
                        return;
                    }

                    if (tbMenthod.tb_EmpInfoRegister(EmpClass) == 1)
                    {
                        MessageBox.Show("注册成功");
                        //intFalg = 0;
                        
                        ClearControls();
                        //ControlStatus();
                        
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                        //intFalg = 0;
                        //tbMenthod.tb_EmpInfoFind("2",dataGridView1);
                        ClearControls();
                        ControlStatus();
                    }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearControls();//清空控件内容
            //ControlStatus();//控件控年状态
            //intFalg = 1;//添加标
        }

        /// <summary>
        /// 控制控件状态
        /// </summary>
        private void ControlStatus()
        {
            this.register.Enabled = !this.register.Enabled;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmLogin frl = new frmLogin();
            frl.Show();
            this.Hide();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
