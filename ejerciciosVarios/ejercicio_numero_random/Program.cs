using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_numero_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comprobar un numero random

            Random numero = new Random();
            int sorteoNumero = numero.Next(20);
            //Console.WriteLine(sorteoNumero);
            bool validacion = true;
            int intentos = 3;
            do
            {

                Console.WriteLine("Adivine el numero");
                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor > sorteoNumero)
                {
                    intentos--;
                    Console.WriteLine("El numero es menor, te quedan {0} intentos", intentos);
                    
                }
                else if (valor < sorteoNumero)
                {
                    intentos--;
                    Console.WriteLine("El numero es mayor te quedan {0} intentos", intentos);
                    
                }
                else
                {
                    Console.WriteLine("Haz adivinado el numero en {0} intentos", intentos);
                    validacion = false;
                }

                if (intentos == 0)
                {
                    validacion = false;
                    Console.WriteLine("No lograste adivinar el numero, alcanzaste el numero de intentos");
                }




            } while (validacion);
        }
    }
}
