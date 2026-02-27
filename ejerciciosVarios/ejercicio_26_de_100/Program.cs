using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_26_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribe un programa que compare dos cadenas y muestre un mensaje si estas son iguales
             */

            string cadena1 = "Hola";
            string cadena2 = "hola";

            if (cadena1 == cadena2)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }
        }
    }
}
