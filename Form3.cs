using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1126
{
    public partial class Form3 : Form
    {
        double numero1, numero2, resultado;
        public Form3()
        {
            InitializeComponent();
        }
        void guardarValores()
        {
            numero1 = Convert.ToDouble(txtNumero1.Text);
            numero2 = Convert.ToDouble(txtNumero2.Text);
        }
        private void btModulo_Click(object sender, EventArgs e)
        {
            guardarValores();
            resultado = numero1 % numero2;
            lbRespuesta.Text = "El resultado de la división modular es " + resultado;
            
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            lbRespuesta.Text = "";
            txtNumero1.Clear();
            txtNumero2.Clear();
        }

        private void btPotencia_Click(object sender, EventArgs e)
        {
            guardarValores();
            resultado = Math.Pow(numero1, numero2);
            lbRespuesta.Text = "El resultado de la potencia es: " + resultado;
        }

        private void btRaizCuadrada_Click(object sender, EventArgs e)
        {
            guardarValores();
            resultado = Math.Sqrt(numero1 + numero2);
            lbRespuesta.Text = "El resultado de la raíz es: " + (resultado);
        }
    }
}
