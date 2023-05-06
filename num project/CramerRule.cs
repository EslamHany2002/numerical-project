using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace num_project
{
    public partial class CramerRule : Form
    {
        public CramerRule()
        {
            InitializeComponent();
        }

        private void CramerRule_Load(object sender, EventArgs e)
        {

        }

        private void btn_sum_Click_1(object sender, EventArgs e)
        {
            double x00 = Convert.ToDouble(txt_00.Text);
            double x01 = Convert.ToDouble(txt_01.Text);
            double x02 = Convert.ToDouble(txt_02.Text);
            double x03 = Convert.ToDouble(txt_03.Text);

            double x10 = Convert.ToDouble(txt_10.Text);
            double x11 = Convert.ToDouble(txt_11.Text);
            double x12 = Convert.ToDouble(txt_12.Text);
            double x13 = Convert.ToDouble(txt_13.Text);

            double x20 = Convert.ToDouble(txt_20.Text);
            double x21 = Convert.ToDouble(txt_21.Text);
            double x22 = Convert.ToDouble(txt_22.Text);
            double x23 = Convert.ToDouble(txt_23.Text);

            double x000 = x00, x001 = x01, x002 = x02, x003 = x03;
            double x110 = x10, x111 = x11, x112 = x12, x113 = x13;
            double x220 = x20, x221 = x21, x222 = x22, x223 = x23;

            // calculate deter A 
            double DA = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            txt_a.Text = DA.ToString();

            // calculate deter A1
            // replace the first col with result 
            x00 = x03; x10 = x13; x20 = x23;
            double DA1 = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            txt_a1.Text = DA1.ToString();

            // calculate deter A2
            // replace the second col with result 
            x00 = x000; x10 = x110; x20 = x220;
            x01 = x03; x11 = x13; x21 = x23;
            double DA2 = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            txt_a2.Text = DA2.ToString();

            // calculate deter A3
            // replace the third col with result 
            x01 = x001; x11 = x111; x21 = x221;
            x02 = x03; x12 = x13; x22 = x23;
            double DA3 = (x00 * ((x11 * x22) - (x12 * x21))) - (x01 * ((x10 * x22) - (x12 * x20))) + (x02 * ((x10 * x21) - (x11 * x20)));
            txt_a3.Text = DA3.ToString();

            //calculate x
            double x1 = DA1 / DA; double x2 = DA2 / DA; double x3 = DA3 / DA;
            txt_x1.Text = x1.ToString();
            txt_x2.Text = x2.ToString();
            txt_x3.Text = x3.ToString();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_00.Text = ""; txt_01.Text = ""; txt_02.Text = ""; txt_03.Text = "";
            txt_10.Text = ""; txt_11.Text = ""; txt_12.Text = ""; txt_13.Text = "";
            txt_20.Text = ""; txt_21.Text = ""; txt_22.Text = ""; txt_23.Text = "";
            txt_a.Text = ""; txt_a1.Text = ""; txt_a2.Text = ""; txt_a3.Text = "";
            txt_x1.Text = ""; txt_x2.Text = ""; txt_x3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_00_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_01_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_a1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_x1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
