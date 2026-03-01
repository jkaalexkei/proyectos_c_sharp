using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_42_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //recorrer un array de enteros y muestra sus valores

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("valores: {0}",string.Join(",",numeros));
        }
    }
}
