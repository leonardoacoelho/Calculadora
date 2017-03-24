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
            try
            {
                double result = Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text);
                lblResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valor numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text);
                lblResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valor numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            try
            {
                double result = Convert.ToDouble(txtNum1.Text) * Convert.ToDouble(txtNum2.Text);
                lblResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valor numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try { 
            double result = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text);
            lblResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite valor numérico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
