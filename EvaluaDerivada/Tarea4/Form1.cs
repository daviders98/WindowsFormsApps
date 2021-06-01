using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, B, N;

            A = double.Parse(a.Text);
            B = double.Parse(b.Text);
            N = double.Parse(n.Text);

            for (i = 0; i <= n; i++)
                trapm();
            double f(double x)
            {
                return (x + 1 / x) * (x + 1 / x);
            }

            double trapm(double a, double b, double n)
            {
                double sum, xi, h; sum = f(a);
                h = (b - a) / n;

                for (int i = 1; i <= n - 1; i++)
                {
                    xi = a + i * h;
                    sum = sum + 2 * f(xi);
                }
                sum = sum + f(b); return h * sum / 2;
            }

        }
    }
}
