using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_36_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribe un programa que use break para salir de un bucle cuando se cumpla una condicion
             */

            int[] numeros = { 1,2,3,4,5,6,7,8};

            for (int i = 0; i < numeros.Length; i++)
            {
                
                if (i == 5)//si se cumple esta condicion
                {
                    Console.WriteLine("fin");
                    break;//finaliza el bucle si la condicion se cumple
                }
                Console.WriteLine(i);
            }


        }
    }
}
