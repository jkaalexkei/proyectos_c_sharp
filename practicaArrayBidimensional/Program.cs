using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaArrayBidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejemplo de matriz bidimensional

            int[,] matriz = { //matriz de 3 filas y 3 columnas
                              { 1, 2, 3 }, 
                              { 4, 5, 6 },
                              { 7, 8, 9 } 
                            };

            int suma = 0; //almacena la operacion a realizar
            //creamos un for para recorrer la matriz
            for (int i=0;i<matriz.GetLength(0);i++)//utilizamos getlength(0) para hacer referencia a las filas
            {
                for (int j = 0; j < matriz.GetLength(1); j++)//utilizamos getlength(0) para hacer referencia a las columnas
                {
                    suma += matriz[i, j];//realizamos y almacena la suma de los valores de la matriz
                }

            }
            Console.WriteLine("La suma de los valores de la matriz es: {0}", suma);
            Console.ReadKey();
        }
    }
}
