using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_16_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declara una variable con tipo de dato implicito y obtener el tipo de dato de la misma

            var variable = 10;//asi declaramos una variable con tipo de dato implicito usando var

            Console.WriteLine(variable.GetType());
        }
    }
}
