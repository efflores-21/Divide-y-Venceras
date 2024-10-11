using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divide_y_Venceras_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMetrosAKilometros_Click(object sender, EventArgs e)
        {
            double metros = Convert.ToDouble(txtValor.Text);
            double kilometros = metros / 1000;
            MessageBox.Show("Kilómetros: " + kilometros);
        }

        private void btnKgAGramos_Click(object sender, EventArgs e)
        {
            double kilogramos = Convert.ToDouble(txtValor.Text);
            double gramos = kilogramos * 1000;
            MessageBox.Show("Gramos: " + gramos);
        }

        private void btnLitrosAMililitros_Click(object sender, EventArgs e)
        {
            double litros = Convert.ToDouble(txtValor.Text);
            double mililitros = litros * 1000;
            MessageBox.Show("Mililitros: " + mililitros);
        }

        private void btnCelsiusAFahrenheit_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(txtValor.Text);
            double fahrenheit = (celsius * 9 / 5) + 32;
            MessageBox.Show("Fahrenheit: " + fahrenheit);
        }

        private void btnHorasAMinutos_Click(object sender, EventArgs e)
        {
            double horas = Convert.ToDouble(txtValor.Text);
            double minutos = horas * 60;
            MessageBox.Show("Minutos: " + minutos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

