using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_38_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             escribe un programa que entre en un bucle infinito y salga con break;
             */
            int numero = 0;

            bool condicion = true;

            while(condicion)
            {
                Console.WriteLine("Ingrese un numero a validar: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if(numero > 5)
                {
                    condicion = false;
                    break;
                }
                else
                {
                    Console.WriteLine("intente otra vez");
                }
            }
            
          
        }
    }
}
