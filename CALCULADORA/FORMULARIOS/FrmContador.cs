using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadorA.FORMULARIOS
{
    public partial class FrmContador : Form
    {
        int contador = 0;
        public FrmContador()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tmrContador.Interval = tbVelocidad.Value * 200;
        }

        private void lblCuenta_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tbVelocidad.Enabled = true;
            tmrContador.Interval = tbVelocidad.Value * 200;
            tmrContador.Enabled = true; 
            tmrContador.Start(); // Inicia el temporizador para que comience a contar


        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false;
            tbVelocidad.Enabled = false;

        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            contador++; // Incrementa el contador en 1 cada vez que se activa el evento Tick del temporizador
            lblCuenta.Text = contador.ToString(); // Actualiza el texto del label con el valor del contador
        }
    }
}
