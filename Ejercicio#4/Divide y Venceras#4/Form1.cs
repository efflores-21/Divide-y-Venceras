using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divide_y_Venceras_4
{
    public partial class Form1 : Form
    {
        double saldo = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo actual: " + saldo);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(txtCantidad.Text);
            saldo += cantidad;
            MessageBox.Show("Depósito realizado. Nuevo saldo: " + saldo);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(txtCantidad.Text);
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
                MessageBox.Show("Retiro realizado. Nuevo saldo: " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo insuficiente.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

