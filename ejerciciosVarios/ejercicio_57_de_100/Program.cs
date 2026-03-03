using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_57_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe dos funciones con el mismo nombre pero diferentes parametros

            int a = 10;
            int b = 20;
            int c = 30;

            Console.WriteLine("total suma de 2 numeros: {0}",suma(a,b ));
            Console.WriteLine("total suma de 3 numeros: {0}",suma(a,b,c ));

        }

        //metodo sobrecargados
        public static int suma(int a, int b)
        {
            return a + b;
        }

        public static int suma(int a, int b, int c)//sobrecarga
        {
            return a + b + c;
        }
    }
}
