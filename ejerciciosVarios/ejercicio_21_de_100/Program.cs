using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_21_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que verifique si un numero es mayor que 10
            int numero = 10;
            int otroNumero;

            Console.WriteLine("Ingrese un numero");
            otroNumero = Convert.ToInt32(Console.ReadLine());

            if (otroNumero > numero)
            {
                Console.WriteLine("El numero ingresado es mayor a {0}",numero);
            }
            else
            {
                Console.WriteLine("el numero ingresado es menor");
            }
        }
    }
}
