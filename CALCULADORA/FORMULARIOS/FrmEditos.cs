using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadorA.FORMULARIOS
{

    public partial class FrmEditor : Form
    {
        bool saved = false;
        string path = "";
        int contador = 0;
        string texto = "";

        public FrmEditor()
        {
            InitializeComponent();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdEditor.ShowDialog() == DialogResult.OK)
                if (File.Exists(ofdEditor.FileName))
                {
                    rtbEditor.Text = File.ReadAllText(ofdEditor.FileName);
                }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter archivo = new StreamWriter(sfdEditor.FileName))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";
            saved = false;
        }

        private void guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtbEditor.Text);
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estadisticas: \nPalabras: " + tssStatus.Text + "\nLetras: " + texto.Length.ToString(), "Contador de palabras: ");
        }


        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
            texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] parrafos = texto.Split(new char[] { '\n'},StringSplitOptions.RemoveEmptyEntries);
            // Contar palabras
                                                                                                                    //la misma línea pero con interpolación de cadenas
                                                                                                                    //tssStatus.Text = palabras.Length.ToString() + " palabras";
            tssStatus.Text = $"Palabras: {palabras.Length} | Caracteres: {texto.Length}";
        }
    }
}
