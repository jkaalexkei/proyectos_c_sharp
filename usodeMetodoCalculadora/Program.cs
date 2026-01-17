using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace usodeMetodoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Ejercicio 1: Calculadora básica
                 Crea un programa que permita al usuario realizar operaciones matemáticas básicas (suma, resta, multiplicación, división) utilizando métodos separados para cada operación. El programa debe solicitar dos números y la operación deseada al usuario y luego mostrar el resultado.
            Reglas:

                Utiliza la estructura Switch Case

                Usa el Console.ReadKey con la propiedad KeyChar para leer el caracter que el usuario ingrese (símbolos que representan las operaciones matémáticas). No utilices Console.RedLine() ya que el programa debe capturar el caracter (char) y no la cadena en la seleción de la operación. Puedes utilizar el siguiente ejemplo:

                Console.Write("Seleccione una operación (+, -, *, /): ");
                ConsoleKeyInfo tecla = Console.ReadKey();
                char operacion = tecla.KeyChar;
                3. El mérodo debe devolver un resultado, significa que no es vacío

             */
            Console.WriteLine("Programa para operaciones matematicas");
            string intento = "si";
            do
            {
                Console.WriteLine("Ingrese una opción: s=sumar, r=restar, m=multiplicar, d=dividir, q=finalizar");
                string valor;
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();
                valor = Convert.ToString(key.KeyChar);
                if (valor == "q")
                {

                    break;
                }
                opcion(valor);
                Console.WriteLine("Desea realizar otra operación escriba si o no");
                intento = Console.ReadLine().ToLower();
                


            } while ( intento != "no");
            Console.WriteLine("Haz Finalizado el programa");


        }

        static void capturarValores(out float a, out float b)
        {
            Console.Write("Ingrese primer valor: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese segundo valor: ");
            b = Convert.ToSingle(Console.ReadLine());
        }
        
        static string opcion(string letra)
        {
            float a, b;
            switch (letra)
            {
                case "s":
                    Console.WriteLine("Operación elegida suma: ");
                    capturarValores(out a, out b);
                    Console.WriteLine($"El resultado de la suma es: {suma(a, b)}");
                    break;
                case "r":
                    Console.WriteLine("Operación elegida resta: ");
                    capturarValores(out a, out b);
                    Console.WriteLine($"El resultado de la resta es: {resta(a, b)}");
                    break;
                case "m":
                    Console.WriteLine("Operación elegida multiplicar: ");
                    capturarValores(out a, out b);
                    Console.WriteLine($"El resultado de la multiplicación es: {multiplicar(a,b)}");
                    break;
                case "d":
                    Console.WriteLine("Operación elegida dividir");
                    capturarValores(out a, out b);
                    float resultado = dividir(a, b);
                    if (b != 0)
                    {
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error, no se puede dividir por cero");
                        break;

                    }
                        
                case "q":
                    Console.WriteLine("Haz finalizado el programa");
                    break;
                default:
                    Console.WriteLine("Operación no contemplada");
                    break;
            }

            return letra;

        }

        static float suma(float a, float b)
        {
            float suma;
            
            suma = a + b;
            return suma;
        }

        static float resta(float a, float b) { 
            float resta;
            resta = a - b;
            return resta;
        }

        static float multiplicar(float a, float b)
        {
            float multiplicar;
            multiplicar = a * b;
            return multiplicar;
        }
        static float dividir(float a, float b)
        {
            float dividir;
            if(b != 0)
            {
                dividir = a / b;
                return dividir;
            }
            else
            {
                return 0.00f;
            }
        }
    }
    
}
