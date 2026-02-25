using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_12_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedir al usuario dos numeros, sumarlos y mostrar el resultado
            int n1, n2, resultado;
            Console.WriteLine("Sumar dos numeros");
            Console.WriteLine("Ingresa numero 1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa numero 2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine("El resultado es: {0}",resultado);



        }
    }
}
