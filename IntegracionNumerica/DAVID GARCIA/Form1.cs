using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAVID_GARCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, N, con, res, ER, resuno;
            A = double.Parse(a.Text);
            B = double.Parse(b.Text);
            N = double.Parse(n.Text);
            con = N;
            string z = " ";

            resuno = 0;
            N = 0;
            do
            {
                N++;
                if (N == 1)
                {
                    resuno = simpson13(A, B);
                    z = "El resultado cuando N es igual a 1 es: " + resuno + " y el error relativo porcentual aproximado no se puede calcular" + Environment.NewLine;
                }
                else
                {
                    res = simpson13multiple(A, B, N);
                    if (N == 2)
                    {
                        ER = Math.Abs((res - resuno) / res);
                    }
                    else
                    {
                        ER = Math.Abs((res - simpson13multiple(A, B, N - 1)) / res);
                    }
                    z += "El resultado cuando N es igual a " + N + " es: " + res + " y el error relativo porcentual aproximado es: " + 100 * ER + Environment.NewLine;
                }
            } while (N < con);


            double f(double x)
            {
                return x * x * (Math.Exp(x));
            }

            double simpson13(double a, double b)
            {
                double x1 = (a + b) / 2;
                return (b - a) * (f(a) + 4 * f(x1) + f(b)) / 6;
            }

            double simpson13multiple(double a, double b, double n)
            {
                double sum, h, x;

                sum = f(a);
                h = (b - a) / n; for (int i = 1; i <= n - 2;)
                {
                    x = a + i * h;
                    sum = sum + 4 * f(x) + 2 * f(x  + h);
                    i += 2;
                }
                sum = sum + 4 * f(b - h) + f(b);
                return h * sum / 3;
            }
            caja.Text = z.ToString();
        }
    }
}
