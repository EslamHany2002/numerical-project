using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Z.Expressions;

namespace num_project
{
    public partial class Bisection : Form
    {

        double xolder = 0;
        double xr = 0;
        double error = 0;
        int counter = 0;

        public Bisection()
        {
            InitializeComponent();
        }

        double f(double xx)
        {
            try
            {
                string func = textBox1.Text;
                double result;
                result = Eval.Execute<double>(textBox1.Text.ToString(), new { x = xx });
                return (Math.Round(result, 3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = " ";
            textBox4.Text = "";

            double xolder = 0;
            double xr = 0;
            double error = 0;
            int counter = 1;
            double xl = 0;
            double xu = 0;

            dataGridView1.Rows.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
                    xr = (xl + xu) / 2;
                    error = Math.Abs((xr - xolder) / xr) * 100;
                    xolder = xr;

                    dataGridView1.Rows.Add(counter.ToString(), Math.Round(xl, 3).ToString(),
                        f(xl).ToString(), Math.Round(xu, 3).ToString(), f(xu).ToString(),
                        Math.Round(xr, 3).ToString(), f(xr).ToString(), Math.Round(error, 3).ToString());
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

                textBox2.Text = Math.Round(xr, 3).ToString();
                textBox6.Text = Math.Round(error, 3).ToString();
            }
            else
                MessageBox.Show("No solution", "Warnning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
