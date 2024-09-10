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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;
            numero1 = Convert.ToInt16(txtNumero1.Text);
            numero2 = Convert.ToInt16(txtNumero2.Text);

            resultado = numero1 * numero2;
            lbRespuesta.Text = "El resultado es: " + resultado.ToString();

        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
