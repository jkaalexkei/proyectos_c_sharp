using System;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDosCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio Cadenas 2: Reversión de Cadena
                Crea un programa tome una cadena de texto ingresada por el usuario y mostrará la misma cadena pero en orden inverso.

                Ejemplo:

                Hola Mundo
                La cadena invertida es:  odnuM aloH
             
             */
            string texto, nuevoTexto;
            Console.WriteLine("Ingrese un texto");
            texto = Console.ReadLine();
            int cant = texto.Length;
            
            nuevoTexto = new String(texto.Reverse().ToArray());//de esta forma devolvemos un texto invertido

            Console.WriteLine(nuevoTexto);
            Console.WriteLine("Forma 2 de invertir un texto");

            string[] invertido = new string[cant];

            for (int i = cant - 1; i >= 0; i--)
            {
                invertido[i] = texto[i].ToString();
                Console.Write(invertido[i]);
            }
            Console.WriteLine("");




            Console.ReadKey();

        }
    }
}
