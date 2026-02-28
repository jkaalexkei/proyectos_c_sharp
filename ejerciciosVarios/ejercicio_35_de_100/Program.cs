using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_35_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribir un programa que recorra un array de numeros usando foreach
             */

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };

            foreach (int item in numeros)
            { 
                Console.WriteLine(item);
            }

            Console.WriteLine("fin");
        }
    }
}
