using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodo_de_la_secante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xzero, xone, cifra;

            xzero = double.Parse(valora.Text);
            xone = double.Parse(valorb.Text);
            cifra = double.Parse(ES.Text);
            string z = " ";
            newtonraphson(xzero, xone, cifra);

            double newtonraphson(double w, double y, double eror)
            {
                int iter = 1;
                double es, a, ea=1000;
                es = (.5 * Math.Pow(10, 2 - eror));

                do
                {
                    a = y - (f(y)*((w-y)) /(f(w)-f(y)));

                    if (a != 0 && iter > 1)
                        ea = Math.Abs((a - y) / y);
                    z += "Para la iteracion numero " + iter + " la raíz es igual a " + a + Environment.NewLine;
                    iter = iter + 1;
                    y = a;
                } while (ea > es);
                return 0;
            }
            double f(double x)
            {
                return (-12-(21*x)+(18*x*x)-(2.4*x*x*x));
            }
            caja.Text = z.ToString();
        }
    }
}
