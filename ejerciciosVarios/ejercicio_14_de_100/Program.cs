using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_14_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //pide al usuario que escriba el nombre por consola, obten el total de caracteres de l nombre, sumarle un numero de punto flotante y muestra el resultado

            string nombre="";
            int longitud = 0;
            double resultado = 0;
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            longitud = nombre.Length;
            Console.WriteLine("El nombre tiene una longitud de: {0} caracteres", longitud);
            resultado = longitud + 1.2;
            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}
