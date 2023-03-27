using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Expressions;

namespace num_project
{
    public partial class FalsePostion : Form
    {
        double xolder = 0;
        double xr = 0;
        double error = 0;
        int counter = 1;
        public FalsePostion()
        {
            InitializeComponent();
        }

        double f(double xx)
        {
            try
            {
                string w = textBox1.Text;
                double result;
                result = Eval.Execute<double>(textBox1.Text.ToString(), new { x = xx });
                return (Math.Round(result, 4));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0d;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xl = Convert.ToDouble(textBox5.Text);
            double xu = Convert.ToDouble(textBox3.Text);
            double Err = Convert.ToDouble(textBox4.Text);

            if (f(xl) * f(xu) < 0)
            {
                do
                {
                    xr = xu - ((f(xu) * (xl - xu)) / (f(xl) - f(xu)));
                    error = Math.Abs((xr - xolder) / xr) * 100;
                    xolder = xr;

                    dataGridView1.Rows.Add(counter.ToString(), Math.Round(xl, 4).ToString(), f(xl).ToString(), Math.Round(xu, 4).ToString(), f(xu).ToString(), Math.Round(xr, 4).ToString(), f(xr).ToString(), Math.Round(error, 4).ToString());
                    counter++;

                    if (f(xl) * f(xr) < 0)
                    {
                        xu = xr;
                    }
                    else if (f(xl) * f(xr) > 0)
                    {
                        xl = xr;
                    }
                } while (error > (Err / 100) * 100);

                textBox2.Text = xr.ToString();
                textBox6.Text = (error).ToString();
            }
            else
                MessageBox.Show("No solution", "Warnning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
    }
}
