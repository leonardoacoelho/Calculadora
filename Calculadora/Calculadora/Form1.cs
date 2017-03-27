using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            lblResult.Text = "0";

            txtNum1.Focus();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            Calculo(Operador.Mais);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            Calculo(Operador.Menos);
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            Calculo(Operador.Vezes);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calculo(Operador.Dividir);   
        }

        public void Calculo(Operador operador)
        {
            try
            {
                var num1 = Convert.ToDouble(txtNum1.Text);
                var num2 = Convert.ToDouble(txtNum2.Text);
                double result = 0;

                if (operador == Operador.Mais)
                    result = num1 + num2;
                else if (operador == Operador.Menos)
                    result = num1 - num2;
                else if (operador == Operador.Vezes)
                    result = num1 * num2;
                else
                    result = num1 / num2;

                lblResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valor numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public enum Operador
    {
        Mais, Menos, Vezes, Dividir
    }
}
