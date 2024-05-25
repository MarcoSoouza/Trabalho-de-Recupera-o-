using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_Recuperação
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double Peso, Altura, Resultado, imc,
           altura = Double.Parse(txtAltura.Text);
            Peso = Double.Parse(txtPeso.Text);
            imc = Peso / (altura * altura);
            lblResultado.Text = imc.ToString();
        }
    }
}

