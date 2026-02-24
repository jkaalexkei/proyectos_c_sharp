using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que divida
            // dos numeros decimales literales y muestre el resultado

            decimal d1, d2, resultado;
            d1 = 23.4m;//se coloca el sufijo m para decimales literales
            d2 = 45.7m;
            resultado = d1 / d2;
            Console.WriteLine($"resultado {resultado:F2}");//forma1
            Console.WriteLine("resultado " + string.Format("{0:F2}",resultado));//forma2
        }
    }
}
