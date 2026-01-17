using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumarNumerosdeunacantidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que tome un número entero y sume todos sus dígitos.*/

            int entero;
            string numero;
            string numeroConvertido;
            int enteroConvertido;
            int suma = 0;
            Console.WriteLine("Programa para convertir un numero entero a string y luego sumar sus digitos");
            Console.Write("Ingrese un numero entero cualquiera: ");
            entero = Convert.ToInt32(Console.ReadLine());
            numero = entero.ToString();

            //recorremos el numero usando foreach

            foreach (char digito in numero)
            {
                Console.WriteLine(digito);
                numeroConvertido = digito.ToString();//convertimos char a string
                enteroConvertido = Convert.ToInt32(numeroConvertido); // convertimos string a int
                suma += enteroConvertido; //sumamos los digitos del numero ingresado
            }
            Console.WriteLine("El número ingresado es {0}",entero);
            Console.WriteLine($"La suma de los digitos del numero {entero} es: {suma}");
            Console.WriteLine("Fin del programa");
            Console.ReadKey();

            /*
             
             Ingrese una cantidad cualquiera: 123
            1
            2
            3
            La suma de los digitos es: 51
            Fin del programa

             
             
             */

        }
    }
}
