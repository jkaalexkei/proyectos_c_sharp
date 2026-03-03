using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_56_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //escribe una funcion recursiva que calcule el factorial de un numero
            //funcion recursiva es una funcion que se llama a si misma

            Console.WriteLine(factorial(5));
        }

        public static int factorial(int numero)
        {
            if(numero <= 1)
            {
                return 1;
            }
            else
            {
                return numero * factorial(numero - 1);//aqui se aplica la recursividad
            }
        }
    }
}
