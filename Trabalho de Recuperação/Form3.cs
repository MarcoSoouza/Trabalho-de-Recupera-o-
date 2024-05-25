using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_de_Recuperação
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void False(object sender, EventArgs e)
        {
            // Torna o botão invisível
            txtValor2.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbQuadrilatero.Checked)
            {
                txtValor1.Visible = true;
                txtValor2.Visible = true;
                txtValor3.Visible = true;
                txtValor4.Visible = true;
            }
            else
            {
                lblResultado.Text = "Nenhuma opção selecionada.";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double diametro,lado1,lado2,lado3,lado4,resultado;

            diametro = Convert.ToDouble(txtValor1.Text);
            lado1 = Convert.ToDouble(txtValor1.Text);
            lado2 = Convert.ToDouble(txtValor2.Text);
            lado3 = Convert.ToDouble(txtValor3.Text);
            lado4 = Convert.ToDouble(txtValor4.Text);

            if (rbCirculo.Checked)
            {
                resultado = 3.14 * ((diametro / 2) * (diametro / 2));
                lblResultado.Text = resultado.ToString();
            }
            else if (rbTriangulo.Checked)
            {
                resultado = lado1 + lado2 + lado3;
                lblResultado.Text = resultado.ToString();
            }
            else if (rbQuadrilatero.Checked) 
            {
                resultado = lado1 + lado2 + lado3 + lado4;
                lblResultado.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Não selecionou nenhuma opção");
            }
            
        }

        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCirculo.Checked)
            {
                txtValor1.Visible = true;
                txtValor2.Visible = false;
                txtValor3.Visible = false;
                txtValor4.Visible = false;
            }
            else
            {
                lblResultado.Text = "Nenhuma opção selecionada.";
            }
        }

        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked)
            {
                txtValor1.Visible = true;
                txtValor2.Visible = true;
                txtValor3.Visible = true;
                txtValor4.Visible = false;
            }
            else
            {
                lblResultado.Text = "Nenhuma opção selecionada.";
            }
        }
    }
    }

