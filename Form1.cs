using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC_Calculator
{
    public partial class formIMCCalc : Form
    {
        public formIMCCalc()
        {
            InitializeComponent();
        }

        private void btnSubm_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;

            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);

            imc = peso / (altura * altura);

            txtIMC.Text = Convert.ToString(imc.ToString("F"));

            if (imc < 17)
            {
                txtSituacao.Text = "Você está muito abaixo do peso";
            }
            else if (imc >= 17 && imc < 18.49)
            {
                txtSituacao.Text = "Você está abaixo do peso";
            }
            else if (imc >= 18.50 && imc < 24.99)
            {
                txtSituacao.Text = "Parabéns! Você está em seu peso ideal!";
            }
            else if (imc >= 25 && imc < 29.99)
            {
                txtSituacao.Text = "Você está acima do peso";
            }
            else if (imc >= 30 && imc < 34.99)
            {
                txtSituacao.Text = "Atenção! Você está com obesidade classe I";
            }
            else if (imc >= 35 && imc < 39.99)
            {
                txtSituacao.Text = "Atenção! Você está com obesidade classe II (severa)";
            }
            else
            {
                txtSituacao.Text = "Muita atenção!!! Você está com obesidade classe III (mórbida)";
            }

            txtSituacao.Enabled = true;
            txtIMC.Enabled = true;
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
            txtSituacao.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
