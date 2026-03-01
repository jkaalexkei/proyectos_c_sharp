using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_41_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             declarar un array de enteros y asignale valores
             */

            Console.WriteLine("Cuantos numeros quieres almacenar");
            int valores = Convert.ToInt32(Console.ReadLine());
            int[] numero = new int[valores];
            Console.WriteLine("Ingresa los numeros a registrar: ");
            for (int i = 0; i < numero.Length;i++)
            {
                Console.Write($"Valor {i+1}: ");
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Valores registrados");
            
            Console.WriteLine(string.Join(",",numero));//separa los numeros por coma mediante el uso del string.joing, no se necesita de un bucle para este tipo de salida de la información
            
        }
    }
}
