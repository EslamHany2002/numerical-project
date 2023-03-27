using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num_project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bisection h = new Bisection();
            h.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bisection h = new Bisection();
            h.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FalsePostion h = new FalsePostion();
            h.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SimpleFixed h = new SimpleFixed();
            h.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Newton h = new Newton();
            h.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Secant h = new Secant();
            h.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
