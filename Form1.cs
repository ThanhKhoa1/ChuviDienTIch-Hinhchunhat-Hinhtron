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

        private void lblketqua_Click_1(object sender, EventArgs e)
        {

        }

        private void btnketqua_Click(object sender, EventArgs e)
        {
            double dai = double.Parse(txtChieudai.Text);
            double rong = double.Parse(txtChieurong.Text);
            lblketqua.Text = "";

            if (cbDT.Checked)
            { 
            lblketqua.Text = " Dien tich : " + TinhDienTich(dai, rong ) + "\n" ;
            }
            if (cbCv.Checked)
            {
                lblketqua.Text += " Chu vi : " + TinhChuvi(dai,rong) + "\n";
            }
        }
        double TinhDienTich(double dai , double rong) { return dai * rong; }
        double TinhChuvi(double dai , double rong) { return (dai + rong) * 2; }

        private void btnketqua2_Click(object sender, EventArgs e)
        {
            lblketqua.Text = "Dien Tich : " + TinhDienTich(double.Parse(txtChieudai.Text),double.Parse(txtChieurong.Text)) + "\n Chu Vi : " + TinhChuvi(double.Parse(txtChieudai.Text),double.Parse(txtChieurong.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dai = double.Parse(txtChieudai.Text);
            double rong = double.Parse(txtChieurong.Text);
            if (rdbCv.Checked) {
                lblkq2.Text = "Chu Vi : " + TinhChuvi(dai, rong);
            }
            if (rdbDt.Checked)
            {
                lblkq2.Text = "Dien Tich : " + TinhDienTich(dai, rong);
            }
            }

        private void txtBankinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
