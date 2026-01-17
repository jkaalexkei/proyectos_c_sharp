using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //hallar el numero escondido
                int numero = 0;
                int contador = 1;
                Console.WriteLine("adivina el numero");
                while (numero != 20)
                {
                    Console.WriteLine("Ingresa un numero");
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (numero == 20)
                    {
                        Console.WriteLine("Haz conseguido el numero {0}", numero);
                    }
                    else if (numero < 20)
                    {
                        Console.WriteLine("!Pista¡,El numero es mayor");
                        contador++;
                    }
                    else if (numero > 20)
                    {
                        Console.WriteLine("!Pista¡, El numero escondido es menor");
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Sigue intentando");
                        contador++;
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Haz ingrezado un dato invalido, fin del programa");
                return;

            }
            
            
            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
