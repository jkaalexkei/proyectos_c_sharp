using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_30_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             escribe un programa que use break y continue en un bucle
             */

            int numero = 4;
            for (int i = 0; i < 10; i++)
            {
                
                if (i == numero) {
                    Console.WriteLine("aqui termina el primer bucle");
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Aqui inicia el segundo bucle");
            for (int j = 0; j < 10; j++)
            {
                
                if (j == numero)
                {
                    Console.WriteLine("salto numero");
                    continue;
                }
                Console.WriteLine(j);
            }
        }
    }
}
