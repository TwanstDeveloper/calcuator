using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcutaion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sum_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtnum1.Text);
            double y = Convert.ToDouble(txtnum2.Text);
            double z = x + y;
            txtresult.Text = z.ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtnum1.Text);
            double y = Convert.ToDouble(txtnum2.Text);
            double z = x - y;
            txtresult.Text = z.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtnum1.Text);
            double y = Convert.ToDouble(txtnum2.Text);
            double z = x / y;
            txtresult.Text = z.ToString();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtnum1.Text);
            double y = Convert.ToDouble(txtnum2.Text);
            double z = x * y;
            txtresult.Text = z.ToString();
        }

        private void plusplus_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtnum1.Text);

            txtnum1.Text =x+1+"" ;
        }

        private void subsub_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtnum2.Text);

            txtnum2.Text = x - 1 + "";
        }
    }
}
