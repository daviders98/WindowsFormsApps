using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSumaMultiplica
{
    public partial class CalculadoraSumaMultiplica : Form
    {
        public CalculadoraSumaMultiplica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, suma, multiplicacion;
            a = double.Parse(valorA.Text);
            b = double.Parse(valorB.Text);

            suma = a + b;
            multiplicacion = a * b;

            resultado.Text = "La suma es: " + suma.ToString() + Environment.NewLine+ " La multiplicacion es: "+ multiplicacion.ToString();
        }
    }
}
