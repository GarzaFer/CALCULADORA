using CalculadorA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadorA.FORMULARIOS
{
    public partial class RegistroAlumnos : Form
    {
        List<Persona> persona = new List<Persona>();
        public RegistroAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            persona.Add(new Persona() { Nombre = txtNombre.Text = txtApellido.Text, Fecha = dtpFecha.Value });
            MessageBox.Show("Alumno registrado con exito");

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabPage2)
            {
               dataGridView1.DataSource = null;
               dataGridView1.DataSource = persona;
            }

        }
    }
}
