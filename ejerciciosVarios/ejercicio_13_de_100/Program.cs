using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_13_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedir al usuario un numero de punto flotante, multiplicalo por dos y muestra el resultado
            double numero;
            double resultado;
            Console.WriteLine("Ingresa un numero decimal: ");
            numero = Convert.ToDouble(Console.ReadLine());
            resultado = numero * 2;
            Console.WriteLine(resultado);
        }
    }
}
