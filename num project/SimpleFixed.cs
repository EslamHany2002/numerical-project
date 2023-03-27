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
    public partial class SimpleFixed : Form
    {
        double Xnew = 0;
        double xi = 0;
        double error = 0;
        int counter = 0;

        public SimpleFixed()
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
                return (Math.Round(result, 3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0.0d;
            }
        }

        private void SimpleFixed_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox5.Text);
            FixedSingle(x0);
        }
        void FixedSingle(double x)
        {
            if (counter == 0)
            {
                xi = x;
                dataGridView1.Rows.Add(counter.ToString(), xi.ToString(), "----");
                counter++;
                FixedSingle(xi);
            }
            else
            {
                xi = x;
                Xnew = f(xi);
                error = Math.Abs((Xnew - xi) / Xnew) * 100;

                dataGridView1.Rows.Add(counter.ToString(), Math.Round(Xnew, 4).ToString(), Math.Round(error, 4).ToString());
                counter++;
                double Err = Convert.ToDouble(textBox3.Text);
                if (error > Err)
                    FixedSingle(Xnew);
            }

            textBox2.Text = Math.Round(Xnew, 3).ToString();
            textBox6.Text = Math.Round(error, 3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox6.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            double x0 = 0;
            double Xnew = 0;

            dataGridView1.Rows.Clear();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
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
