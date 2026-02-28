using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_37_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribe un programa que use continue para saltar una iteraccion en un bucle
            cuando sea numero par
             */

            int[] numeros = { 1,2,3,4,5,6,7,8,9,10};

            foreach (int i in numeros) 
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} es par");
                    continue;
                }
                Console.WriteLine(i);
            
            }
            Console.WriteLine();
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} es par");
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
