using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_34_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribe un programa que imprima una tabla de multiplicar usando for
             */
            int tabla = 3;
            Console.WriteLine($"tabla del {tabla}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1} x {tabla} = {(i+1)*tabla}");
            }
        }
    }
}
