using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodo_Newton_Raphson_A01740055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xzero, es, xuno;

            xzero = double.Parse(valor.Text);
            es = double.Parse(error.Text);
            string z = " ";
            newtonraphson(xzero, es);

            double newtonraphson(double x, double ERROR)
            {
                int iter = 1;
                double ea=1000;

                do
                {
                    xuno = x - (f(x) / fprima(x));
                    
                    if (xuno != 0 && iter > 1)
                        ea = Math.Abs((xuno - x) / xuno) * 100;

                    z += "Para la iteracion numero " + iter + " la raíz es igual a " + xuno+ Environment.NewLine;
                    iter = iter + 1;
                    x = xuno;
                } while (ea > ERROR);
                return 0;
            }
            double f(double x)
            {
                return (-(x*x)+1.8*x+2.5);
            }
            double fprima(double x)
            {
                return (-2 * x + 1.8);  
            }
            caja.Text = z.ToString();
        }
    }
}
