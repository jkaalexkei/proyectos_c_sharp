using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_53_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe una funcion que devuelva el cuadrado de un numero
            Console.WriteLine(cuadrado(9));
        }
         
        public static int cuadrado(int numero)
        {
            return numero * numero;
        }
    }
}
