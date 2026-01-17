using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoSentenciaBreakbuclefor_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crea un programa que solicite al usuario un número entre 1 y 20, luego haga el recorrido y se detenga en el número ingresado por el usuario.
             */
            int numero;
            int valor = 20;
            Console.WriteLine("Validacion de un numero");
            Console.Write("Ingrese un numero entre 1 y 20: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= valor;i++)
            {
                Console.WriteLine(i);
                if (i == numero)
                {
                    Console.WriteLine("Conseguiste el numero {0}", i);
                    break;
                }
            }
            Console.WriteLine("Fin del programa");
            Console.ReadKey();

         
        }
    }
}
