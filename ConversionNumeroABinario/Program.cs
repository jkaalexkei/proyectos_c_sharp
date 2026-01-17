using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionNumeroABinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string valorConvertir;
        inicio:
            Console.WriteLine("Ingrese un numero entre 1 y 20 para validar: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 1; i <= 20;i++)
            {
                if (i == numero)
                {
                    valorConvertir = Convert.ToString(i, 2);
                    Console.WriteLine("El numero encontrado en binario es {0}", valorConvertir);
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            goto inicio;
        }
    }
}
