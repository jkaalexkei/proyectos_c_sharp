using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_51_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe una funcion que sume dos numeros y devuelva el resultado
            Console.WriteLine("Ingrese dos numeros a sumar: ");
            Console.Write("Numero 1: "); 
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma de los numeros es: {0}",sumaNumeros(a,b));
        }

        static public int sumaNumeros(int a, int b)
        {
            return a + b;
        }
    }
}
