using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_32_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * escribe un programa que imprima
             * los numeros del 1 al 10
             * usando el bucle while
             */

            int contador = 1;
            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.WriteLine("fin");
        }
    }
}
