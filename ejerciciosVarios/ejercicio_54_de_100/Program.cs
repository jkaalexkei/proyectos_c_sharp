using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_54_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe una funcion que tome un parametro opcional o parametro por defecto


            Console.WriteLine("Hola " + Saludar("Alex"));
            Console.WriteLine("Hola " + Saludar());

        }

        public static string Saludar(string valor = "Sin Nombre")//funcion con parametro por defecto
        {
            return valor;
        }
    }
}
