using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Validar pallindromo

            //string palabra1;
            //string palabra2 = "";

            //Console.WriteLine("Ingrese palabra 1: ");
            //palabra1 = Console.ReadLine();


            //for (int i = palabra1.Length - 1; i >= 0; i--)
            //{
            //    palabra2 += palabra1[i];
            //}

            //if (palabra1 == palabra2)
            //{
            //    Console.WriteLine("Es palindromo");
            //}
            //else
            //{
            //    Console.WriteLine("No es palindromo");
            //}

            //bucle while

            //int[] numeros = {1,2,3,4,5,6 };

            //int contador = 0;
            //while (numeros.Length > contador)
            //{
            //    if(contador > numeros.Length)
            //    {
            //        Console.WriteLine("Fin");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(numeros[contador]);

            //    }
            //    contador++;

            //}

            //validar contraseña
            int clave = 123;
            int intentos = 3;
            bool acierto = false;
            while (acierto == false)
            {
                Console.WriteLine("Ingrese la clave");
                int dato = Convert.ToInt32(Console.ReadLine());
                if (dato == clave) { 
                    Console.WriteLine("Bienvenido");
                    acierto = true;
                }
                intentos--;
                
                
                if(intentos == 0)
                {
                    Console.WriteLine("Haz consumido el total de intentos");
                    break;
                    
                }
                Console.WriteLine($"Intenta de nuevo te quedan {intentos} intentos");

            }
            Console.WriteLine("Fin de la ejecución");
            
           
        }
    }
}
