using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDosArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             
            Ejercicio 2: Valor máximo del array (Unidimensional)

            Crea un programa que solicite al usuario que ingrese el tamaño de una array y luego indique los valores de ese array y luego encuentre el valor máximo en la matriz.
             
             */

            int cantidad, mayor;

            int[] numeros;

            Console.WriteLine("Ingrese la cantidad de valores a validar:");
            cantidad = Convert.ToInt32(Console.ReadLine());

            numeros = new int[cantidad];

            Console.WriteLine("Ingrese los numeros a validar: ");
            for (int i = 0; i < numeros.Length;i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

            }

            mayor = numeros[0];

            for (int n = 0; n < numeros.Length;n++)
            {
                if (numeros[n] > mayor)
                {
                    mayor = numeros[n];
                }
            }

            Console.WriteLine($"El numero mayor del array es: {mayor}");
            Console.ReadKey();











        }
    }
}
