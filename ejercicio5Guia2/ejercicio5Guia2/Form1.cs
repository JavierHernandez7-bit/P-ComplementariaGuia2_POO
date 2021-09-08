using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5Guia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            listbArreglo.Items.Add(txbNumero.Text); 
            txbNumero.Clear(); 
            txbNumero.Focus();
        }

        private void btnCalc1_Click(object sender, EventArgs e)
        {
            int mayorneg = -1000; for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString(); int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > mayorneg)
                    {
                        mayorneg = numero; txbCalculo1.Text = mayorneg.ToString();
                    }
                }
                else
                {
                    txbCalculo1.Text = "No hay números negativos pares";
                }
            }
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            double cantidadnumeros = listbArreglo.Items.Count;
            double cantidadceros = 0; double porcentaje = 0;
            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString(); 
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100; txbCalculo2.Text = porcentaje.ToString() + "%";
        }

        private void btnCalculo3_Click(object sender, EventArgs e)
        {
            double prom; double cantidadimpares = 0; double suma = 0;
            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString(); int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero; cantidadimpares = cantidadimpares + 1;
                }
            }
            prom = suma / cantidadimpares; txtCalculo3.Text = prom.ToString();
        }

        private void btnCalculo4_Click(object sender, EventArgs e)
        {
            int mayor = 0;
            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString(); int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor) mayor = numero;
                }
            }
            txbCalculo4.Text = mayor.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mayorneg = -1000; for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString(); int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > mayorneg)
                    {
                        mayorneg = numero; txbCalculo1.Text = mayorneg.ToString();
                    }
                }
                else
                {
                    txbCalculo1.Text = "No hay números negativos pares";
                }
            }
            double cantidadnumeros = listbArreglo.Items.Count;
            double cantidadceros = 0; double porcentaje = 0;
            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100; txbCalculo2.Text = porcentaje.ToString() + "%";

            double prom; double cantidadimpares = 0; double suma = 0;
            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString(); int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero; cantidadimpares = cantidadimpares + 1;
                }
            }
            prom = suma / cantidadimpares; txtCalculo3.Text = prom.ToString();

            int mayor = 0;
            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString(); int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor) mayor = numero;
                }
            }
            txbCalculo4.Text = mayor.ToString();
        }
    }
}
