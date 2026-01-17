using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaArreglosJagged
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //registro de valores
            /*
            int[][] jaggedArray = new int[2][]
            {
                new int[5]{1,2,3,4,5},
                new int[3]{1,2,3}
            };

            for (int c = 0; c < jaggedArray.Length;c++)
            {
                Console.Write($"columnas->{jaggedArray[c].GetLength(0)}");

                for (int f = 0; f < jaggedArray[c].Length;f++)
                {
                    Console.Write($" filas->{jaggedArray[c][f]}");
                }
                Console.WriteLine();
            }

            */

            int columna, fila;
            Console.WriteLine("Ingrese la cantidad de columnas del array");
            columna = Convert.ToInt32(Console.ReadLine());

            int[][] jaggedArray = new int [columna][];

            for (int c=0; c < columna;c++)
            {
                Console.WriteLine($"cantidad de filas para la columna {c}");

                fila = Convert.ToInt32(Console.ReadLine());

                jaggedArray[c] = new int[fila];

                for (int f = 0; f < fila;f++)
                {
                    Console.WriteLine($"ingrese los valores {jaggedArray[c][f]}");

                    jaggedArray[c][f] = Convert.ToInt32(Console.ReadLine());
                }
                
            }






        }
    }
}
