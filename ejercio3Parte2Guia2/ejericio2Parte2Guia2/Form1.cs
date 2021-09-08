using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejericio2Parte2Guia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btncalcula_Click(object sender, EventArgs e)
        {
            //declaración de variables de tipo Double
            double a, b, c, x1, x2, calculoX1, calculoX2, X3, cuadrado;
             //obtenemos las variables a, b y c de losTextBox txta,txtb y txtc
             //para poder usarlas las convertimos a tipo Double
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);
            //realizamos la operación de la fórmulageneral, para obtener los dos valores de x
            // se repite la operación sólo se cambia el signo delresultado de la raíz
            //Math.sqrt determina la raíz cuadrada y Math.Pow se usapara potenciar una variable
            cuadrado = Math.Pow(b, 2);
            calculoX1 = cuadrado - 4*a*c;
            x1 = (-b + (Math.Sqrt(calculoX1)))/(2*a);
            // = (-b + (Math.Sqrt((Math.Pow(b, 2)) – (4 * a * c)))) / (2 * a);
            //x2 = (-b – (Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c)))) / (2 * a);
            calculoX2 = cuadrado - 4*a*c;
            x2 = (-b - (Math.Sqrt(calculoX2))) / (2 * a);
            //se imprimen los resultados de las x en susrespectivas etiquetas
            lbx1.Text = x1.ToString();
            lbx2.Text = x2.ToString();
            //las etiquetas se vuelven visibles pues supropiedad visible estaba en false
            lbx1.Visible = true;
            lbx2.Visible = true;
        }

        private void lbx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
