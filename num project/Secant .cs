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
    public partial class Secant : Form
    {
        double Xold = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;
        double xnew = 0;

        public Secant()
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Secant_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox6.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xol = Convert.ToDouble(textBox5.Text);
            double x0 = Convert.ToDouble(textBox2.Text);
            Secan(xol, x0);
        }
        void Secan(double xol, double x0)
        {

            if (counter == 0)
            {
                Xold = xol;
                xi = x0;
                dataGridView1.Rows.Add(counter.ToString(), Xold.ToString(), Math.Round(f(Xold), 4).ToString(), xi.ToString(), Math.Round(f(xi), 4).ToString(), "---");
                counter++; Secan(Xold, xi);
            }
            else
            {
                Xold = xol;
                xi = x0;
                xnew = xi - ((f(xi) * (Xold - xi)) / (f(Xold) - f(xi)));
                error = Math.Abs((xnew - xi) / xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(), Math.Round(xi, 4).ToString(), Math.Round(f(xi), 4).ToString(), Math.Round(xnew, 4).ToString(), Math.Round(f(xnew), 4).ToString(), Math.Round(error, 4).ToString());
                counter++;
                double Err = Convert.ToDouble(textBox3.Text);
                if (error > Err)
                    Secan(xi, xnew);
            }
            textBox4.Text = Math.Round(xnew, 4).ToString();
            textBox6.Text = Math.Round(error, 4).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
