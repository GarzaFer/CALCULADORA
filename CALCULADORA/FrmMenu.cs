using CalculadorA.FORMULARIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadorA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora CalculadoraSimple = new Calculadora();
            CalculadoraSimple.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBurbuja burbuja = new FrmBurbuja();
            burbuja.Show();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAlumnos registro = new RegistroAlumnos();
            registro.Show();
        }
    }
}
