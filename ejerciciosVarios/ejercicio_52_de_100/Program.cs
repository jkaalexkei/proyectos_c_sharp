using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_52_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribe una funcion que tome dos numeros como parametros y devuelva su suma
             */
            int n1 = 10;
            int n2 = 20;
            Console.WriteLine(sumaNumeros(n1,n2));

        }

        public static int sumaNumeros(int n1, int n2)// funcion que recibe dos valores como parametros
        {
            return n1 + n2;
        }
    }
}
