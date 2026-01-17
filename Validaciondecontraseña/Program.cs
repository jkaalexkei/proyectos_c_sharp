using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Validaciondecontraseña
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Ejercicio Do While 2: Ingreso de contraseña hasta la correcta
             Crea un programa que le solicite al usuario ingresar una contraseña y continuará solicitándola hasta que ingrese la contraseña correcta.

             Reglas:
                  Usa una estructura if dentro del ciclo*/

            string clave = "123abc";
            bool validacion = true;
            string valor;
            Console.WriteLine("Programa para validar la contraseña");
            do
            {
                Console.Write("Ingresa la contraseña: ");
                valor = Console.ReadLine();
                if(valor == clave)
                {
                    validacion = false;
                    Console.WriteLine("Haz conseguido la clave");
                }
                else
                {
                    Console.WriteLine("Vuelve a intentarlo");
                    validacion = true;
                }

            } while (validacion != false);
            Console.WriteLine("Fin del programa");
            Console.ReadKey();

            
        }
    }
}
