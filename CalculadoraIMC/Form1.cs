using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CalculadoraIMC
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txbPeso.Text == "")
            {
                MessageBox.Show("preencha o Peso !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbAltura.Text == "")
            {
                MessageBox.Show("Preencha a Altura !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txbAltura.Text) == 0 )
            {
                MessageBox.Show("Altura não pode ser 0 !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double peso = double.Parse(txbPeso.Text);
                double altura = double.Parse(txbAltura.Text);
                double resultado = peso / Math.Pow(altura, 2);

                txbIMC.Text = resultado.ToString();

                if (resultado < 18.5)
                {
                    lblSaude.Text = "você está abaixo do peso";
                    lblSaude.ForeColor = Color.Teal;
                }
                else if (resultado >= 18.5 && resultado <= 24)
                {
                    lblSaude.Text = "seu peso está ideal";
                    lblSaude.ForeColor = Color.Green;
                }
                else if (resultado >= 25.0 && resultado <= 29.9)
                {
                    lblSaude.Text = "você está levemente acima do peso";
                    lblSaude.ForeColor = Color.Orange;
                }
                else if (resultado >= 30.0 && resultado <= 34.9)
                {
                    lblSaude.Text = "você esta com obesidade grau 1";
                    lblSaude.ForeColor = Color.OrangeRed;
                }
                else if (resultado >= 35.0 && resultado <= 40.0)
                {
                    lblSaude.Text = "você está com obesidade grau 2 (severa)";
                    lblSaude.ForeColor = Color.DarkOrange;
                }
                else
                {
                    lblSaude.Text = "você esta com obesidade grau 3 (morbida)";
                    lblSaude.ForeColor = Color.DarkRed;
                }

            }
        }
    }

}


