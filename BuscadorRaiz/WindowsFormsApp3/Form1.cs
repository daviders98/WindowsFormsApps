using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, xr;

            a = double.Parse(limin.Text);
            b = double.Parse(limsup.Text);
            c = double.Parse(Es.Text);
            mbiseccion(a, b, c, 1000);

            double mbiseccion(double xl, double xu, double es, int imax)
            {
                int iter = 1;
                double ea = 1000, test, xrold;

                xrold = (xl + xu) / 2;
                do
                {
                    xr = (xl + xu) / 2;

                    test = f(xl) * f(xr);
                    if (test < 0) xu = xr;
                    else
                        if (test > 0) xl = xr;
                    else ea = 0;

                    if (xr != 0 && iter > 1)
                        ea = Math.Abs((xr - xrold) / xr) * 100;

                    if (iter > 1)
                        xrold = xr;

                    iter = iter + 1;
                } while ((ea >= es) && (iter < imax));
                return xr;
            }
            double f(double x)
            {
                return (4 * x * x * x) - (6 * x * x) + (7 * x) - 2.3;
            }
            MessageBox.Show("la raíz es: " + xr);
        }
    }
}
