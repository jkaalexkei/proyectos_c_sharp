using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioSeisArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Ejercicio 1 Array Jagged: Contar elementos de cada subarray
                Crea un array jagged que realice el conteo del número de elementos en cada uno de sus subarrays

                Reglas:

                Ejemplo de salida por pantalla:

                    El subarray 0 tiene 3 elementos
                    El subarray 1 tiene 2 elementos
                    El subarray 2 tiene 4 elementos
             
             */
            int columnas;//variable para almacenar la cantidad de columnas
            int[][] jagged;//declaramos el array jagged
            Console.WriteLine("Validación de elementos de un array Jagged");
            columnas = Convert.ToInt32(Console.ReadLine());//agregamos el numero de columnas que tendra el arreglo jagged

            jagged = new int[columnas][];//inicializamos el arreglo jagged

            for (int c = 0; c < columnas;c++)//recorremos las columnas del arreglo
            {
                Console.WriteLine("Ingrese el numero de filas para la columna {0}", c);
                jagged[c] = new int[Convert.ToInt32(Console.ReadLine())];//agregamos el numero de filas por columna que tendra el arreglo
            }

            for (int c = 0; c < columnas; c++)//recorremos las columnas 
            {
               
                    Console.WriteLine("El subarray {0} tienen {1} elementos", c, jagged[c].GetLength (0));//mostramos por pantalla la cantidad de columnas y filas por columna que tiene el array
                
            }

        }
    }
}
