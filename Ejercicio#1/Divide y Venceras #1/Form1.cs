using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divide_y_Venceras__1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double resultado = num1 + num2;
            MessageBox.Show("Resultado: " + resultado);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double resultado = num1 - num2;
            MessageBox.Show("Resultado: " + resultado);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double resultado = num1 * num2;
            MessageBox.Show("Resultado: " + resultado);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            if (num2 != 0)
            {
                double resultado = num1 / num2;
                MessageBox.Show("Resultado: " + resultado);
            }
            else
            {
                MessageBox.Show("No se puede dividir por cero.");
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            double resultado = Math.Pow(num1, num2);
            MessageBox.Show("Resultado: " + resultado);
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double resultado = Math.Sqrt(num1);
            MessageBox.Show("Resultado: " + resultado);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

