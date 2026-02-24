using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribe un programa
            que calcule el modulo de dos numeros enteros
            y muestre el resultado
             
             */
            int n1, n2, resModulo;

            n1 = 7;
            n2 = 2;

            resModulo = n1 % n2;//retorna el residuo de una división

            Console.WriteLine("El modulo es: {0}",resModulo);

        }
    }
}
