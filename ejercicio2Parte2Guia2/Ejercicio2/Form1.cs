using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double n1=0, n2=0;
            n1 = Double.Parse(txt1.Text);
            if (rbtn1.Checked == true)
            {
                n2 = (n1*9/5)+32;
                txt2.Text = n2.ToString() + "° Farenheit";
            }
            else if (rbtn2.Checked == true)
            {
                n2 = n1* 3.28084;
                txt2.Text = n2.ToString() + " pies";
            }
            else if (rbtn3.Checked == true)
            {
                n2 = n1 * 2.20462;
                txt2.Text = n2.ToString() + " libras";
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
