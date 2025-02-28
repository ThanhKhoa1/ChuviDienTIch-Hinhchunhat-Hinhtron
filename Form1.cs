using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuvihinhchunhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
           
        }

        private void lblketqua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBang_Click_1(object sender, EventArgs e)
        {
            int chieudai = Convert.ToInt32(txtChieudai.Text);
            int chieurong = Convert.ToInt32(txtChieurong.Text);
            lblChuvi.Text = " Chu vi : " + (chieudai + chieurong) * 2 ;
            lblDientich.Text = " Dien tich : " + (chieudai * chieurong);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int duongkinh = Convert.ToInt32(txtDuongkinh.Text);
            int bankinh = Convert.ToInt32(txtBankinh.Text);
            lblCv.Text = "CV hinh tron : " + (duongkinh * Math.PI);
            lblDt.Text = "DT hinh tron : " + (bankinh * 2 * Math.PI);
        }
    }
}
