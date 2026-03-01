using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_39_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             escribe un programa que imprima las tablas de multiplicar usando bucle for anidado
             */

            //bucle para la tabla correspondiente al numero

            //bucle por el que se va a multiplicar

            for (int tabla = 1; tabla <= 10; tabla++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Tabla del {tabla}:");
                Console.WriteLine("------------------------");
                for (int numero = 1;numero <=10;numero++)
                {
                    Console.WriteLine($"{numero} x {tabla} = {numero * tabla}");
                }
                Console.WriteLine("****************************");
            }
            Console.WriteLine("fin");
        }
    }
}
