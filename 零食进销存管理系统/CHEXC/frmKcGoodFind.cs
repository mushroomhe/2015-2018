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
    public partial class frmKcGoodFind : Form
    {
        public frmKcGoodFind()
        {
            InitializeComponent();
        }

        tb_KcGoodsMenthod tb_GoodMenthd = new tb_KcGoodsMenthod();
        tb_KcGoods kcgood = new tb_KcGoods();
  
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmKcGoodFind_Load(object sender, EventArgs e)
        {

        }
    }
}