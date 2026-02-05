using CalculadorA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculadorA
{
    public partial class FrmBurbuja : Form
    {
        public FrmBurbuja()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            Ordenamientos ordenamiento = new Ordenamientos();   

            int[] ordenado = new int[dgbDesordenado.RowCount];

            for (int i = 0; i < dgbDesordenado.RowCount-1; i++)
            {
                ordenado[i] = Convert.ToInt32(dgbDesordenado.Rows[i].Cells[0].Value);
            }
            ordenado = ordenamiento.Burbuja(ordenado);

            //defineel tamaño de las filas del datagridview de acuerdo al tamaño del arreglo
            dgbOrdenado.DataSource = ordenado;

            //Llenar el datagridview con el arreglo ordenado
            for (int i = 0; i < ordenado.Length; i++)
            {
                dgbOrdenado.Rows[i].Cells[0].Value = ordenado[i];
            }

        }




    }
}
