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
    public partial class frmSellGoodInfo : Form
    {
        public frmSellGoodInfo()
        {
            InitializeComponent();
        }

        tb_ThGoodsMenthod tbthGood = new tb_ThGoodsMenthod();
        private void frmSellGoodInfo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}