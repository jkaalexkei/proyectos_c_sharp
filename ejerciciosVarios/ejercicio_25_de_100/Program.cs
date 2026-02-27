using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_25_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribe un programa que verifique si un numero es mayor que 10 y menor que 20
             */

            Console.WriteLine("Ingrese un numero entre 10 y 20");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero > 10 && numero < 20)
            {
                Console.WriteLine("El numero esta entre 10 y 20");
            }
            else
            {
                Console.WriteLine("el numero esta fuera del rango indicado");
            }
        }
    }
}
