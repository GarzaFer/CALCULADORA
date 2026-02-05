using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadorA.Clases
{
    internal class Ordenamientos
    {
        int[] arreglo;
        public int[] Burbuja(int[] arreglo)
        {
            try
            {
                this.arreglo = arreglo;
                int aux;
                for (int i = 0; i < this.arreglo.Length - 1; i++)
                {
                    for (int j = 0; j < this.arreglo.Length - 1; j++)
                    {
                        if (arreglo[j] > arreglo[j + 1])
                        {
                            aux = arreglo[j];
                            arreglo[j] = arreglo[j + 1];
                            arreglo[j + 1] = aux;
                        }
                    }
                }
                return arreglo;


            }
            catch (Exception Ex)
            {
                throw;
                return null;
            }
        }
    }
}
