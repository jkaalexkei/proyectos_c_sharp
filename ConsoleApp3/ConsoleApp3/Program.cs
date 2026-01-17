using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Calculadora");
            //Console.ReadKey();
            //float num = 10.3f;
            //double num2 = 12.0d;
            //decimal num3 = 13.0m;

            Console.WriteLine("Programa calculadora");

            Console.WriteLine("Ingrese el operador: suma(+) resta(-) multiplicacion(*) division(/)");
            string operador = Console.ReadLine();
            int resultado = 0;

            Console.WriteLine("Ingrese primer numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (operador == "+") 
            {
                resultado = num1 + num2;
                Console.WriteLine("el resultado de la suma es {0}", resultado);
            } else if (operador == "-")
            {
                resultado = num1 - num2;
                Console.WriteLine("El resultado de la resta es {0}", resultado);
            }else if (operador == "*")
            {
                resultado = num1 * num2;
                Console.WriteLine("El resultado de la multiplicación es {0}", resultado);
            }else if(operador == "/")
            {
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la división es {0}", resultado);
            }
            else
            {
                Console.WriteLine("El operador ingresado es incorrecto o no existe");
                Console.ReadKey();
            }


                ;


        }
    }
}
