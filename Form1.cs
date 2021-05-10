using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form

    {
        int valorAnterior = 0;
        int valorPosterior = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtbValorAnterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbValorPosterior_TextChanged(object sender, EventArgs e)
        {

        }
        public void compararNumeros(int valorAnterior, int valorPosterior)
        {
            if (valorAnterior == valorPosterior)
                MessageBox.Show("Los numeros son iguales");
            else if (valorAnterior > valorPosterior)
                MessageBox.Show("El primer numero es mayor al segundo");
            else
                MessageBox.Show("El primer numero es menor al segundo");

        }

        private void comparar_Click(object sender, EventArgs e)
        {
            valorAnterior = Int32.Parse(txtbValorAnterior.Text);
            valorPosterior = Int32.Parse(txtbValorPosterior.Text);
            compararNumeros(valorAnterior,valorPosterior);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}