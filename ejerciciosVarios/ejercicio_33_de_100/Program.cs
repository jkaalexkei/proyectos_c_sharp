using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_33_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribe un programa que imprima 
            los numeros del 1 al 10
            usando un bucle do while
             */

            int contador = 1;
            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while (contador <=10);
        }
    }
}
