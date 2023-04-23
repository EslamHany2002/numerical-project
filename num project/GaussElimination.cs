using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace num_project
{
    public partial class GaussElimination : Form
    {
        double m21 = 0,
               m31 = 0,
               m32 = 0;
        

        double x1 = 0,
               x2 = 0,
               x3 = 0;
        public GaussElimination()
        {
            InitializeComponent();
        }

        private void GaussElimination_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_r11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_00_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r22_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r21_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_x3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r23_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_23_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_22_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sum_Click(object sender, EventArgs e)
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

            m21 = x10 / x00;
            m31 = x20 / x00;
            /*m21 = Math.Round(m21, 3);
            m31 = Math.Round(m31, 3);*/

            x10 = x10 - (m21*x00);
            x11 = x11 - (m21*x01);
            x12 = x12 - (m21*x02);
            x13 = x13 - (m21*x03);

            /*x10 = Math.Round(x10, 3);
            x11 = Math.Round(x11, 3);
            x12 = Math.Round(x12, 3);
            x13 = Math.Round(x13, 3);*/

            x20 = x20 - (m31 * x00);
            x21 = x21 - (m31 * x01);
            x22 = x22 - (m31 * x02);
            x23 = x23 - (m31 * x03);

            /*x20 = Math.Round(x20, 3);
            x21 = Math.Round(x21, 3);
            x22 = Math.Round(x23, 3);
            x23 = Math.Round(x23, 3);*/
            

            m32 = x21 / x11;
            /*m32 = Math.Round(m32, 3);*/

            x20 = x20 - (m32 * x10) ;
            x21 = x21 - (m32 * x11) ;
            x22 = x22 - (m32 * x12) ;
            x23 = x23 - (m32 * x13) ;

            /*x20 = Math.Round(x20, 3);
            x21 = Math.Round(x21, 3);
            x22 = Math.Round(x22, 3);
            x23 = Math.Round(x23, 3);*/

            txt_r00.Text = x00.ToString();
            txt_r01.Text = x01.ToString();
            txt_r02.Text = x02.ToString();
            txt_r03.Text = x03.ToString();

            txt_r10.Text = x10.ToString();
            txt_r11.Text = x11.ToString();
            txt_r12.Text = x12.ToString();
            txt_r13.Text = x13.ToString();

            txt_r20.Text = x20.ToString();
            txt_r21.Text = x21.ToString();
            txt_r22.Text = x22.ToString();
            txt_r23.Text = x23.ToString();

            x3 = x23 / x22;
            x2 = (x13 - (x12 * x3)) / x11;
            x1 = (x03 - (x01 * x2) - (x02 * x3)) / x00;
            /*x1 = Math.Round(x1, 3);
            x2 = Math.Round(x2, 3);
            x3 = Math.Round(x3, 3);*/

            txt_x1.Text = x1.ToString();
            txt_x2.Text = x2.ToString();
            txt_x3.Text = x3.ToString();

            txt_m21.Text = m21.ToString();
            txt_m31.Text = m31.ToString();
            txt_m32.Text = m32.ToString();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_00.Text = "";  txt_01.Text = "";
            txt_02.Text = "";  txt_03.Text = "";

            txt_10.Text = "";  txt_11.Text = "";
            txt_12.Text = "";  txt_13.Text = "";

            txt_20.Text = "";  txt_21.Text = "";
            txt_22.Text = "";  txt_23.Text = "";

            txt_x1.Text = "";  txt_x2.Text = "";  txt_x3.Text = "";
            txt_m21.Text= "";  txt_m31.Text= "";  txt_m32.Text= "";

            txt_r00.Text = ""; txt_r01.Text = "";
            txt_r02.Text = ""; txt_r03.Text = "";

            txt_r10.Text = ""; txt_r11.Text = "";
            txt_r12.Text = ""; txt_r13.Text = "";

            txt_r20.Text = ""; txt_r21.Text = "";
            txt_r22.Text = ""; txt_r23.Text = "";

        }
    }
}
