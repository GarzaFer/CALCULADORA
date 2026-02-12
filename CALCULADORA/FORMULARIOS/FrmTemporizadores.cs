using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;
using CSCore.SoundOut;

namespace CalculadorA.FORMULARIOS
{
    public partial class FrmTemporizadores : Form
    {
        String alarma;
        public FrmTemporizadores()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            if (lblHora.Text == alarma)
                {
                SoundPlayer player = new SoundPlayer(@"C:\Users\garza\OneDrive\Escritorio\UNIVERSIDAD\SEMESTRE 4 ENE-JUN\TOPICOS AVANZADOS DE PROGRAMACION\SONIDOS\dragon-studio-rooster-crowing-364473.mp3");
                MessageBox.Show("ALARMA");
                player.Play();
            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma = Interaction.InputBox("Ingrese la hora", "Configurar Alarma", "00:00:00 x.x");
        }
    }
}
