using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_24_de_100
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
            do {

                Console.WriteLine("Adivine el numero");
                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor > sorteoNumero)
                {
                    Console.WriteLine("El numero es menor, te quedan {0} intentos",intentos);
                    intentos--;
                }
                else if (valor < sorteoNumero)
                {
                    Console.WriteLine("El numero es mayor te quedan {0} intentos", intentos);
                    intentos--;
                }
                else
                {
                    Console.WriteLine("Haz adivinado el numero en {0} intentos",intentos);
                    validacion = false;
                }

                if(intentos ==0)
                {
                    validacion = false;
                    Console.WriteLine("No lograste adivinar el numero, alcanzaste el numero de intentos");
                }
                



            } while (validacion);
            
           
            
            //programa que valide si un numero impar, en caso que sea par se salga de la aplicacion

            //int numero = 0;
            //bool validacion = true;
            //do
            //{
            //    Console.WriteLine("Ingrese un numero para validar si par o impar: ");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    if(numero % 2 == 0)
            //    {
            //        validacion = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("El numero es impar, intente otra vez");
            //    }


            //} while (validacion);
            //Console.WriteLine("conseguiste un numero par");
           
        }
    }
}
