using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoPotenciaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ejercicio 3: Potencia
                Crea un programa que permita al usuario calcular la potencia de un número utilizando un método. El programa debe solicitar un número base y un exponente, y luego mostrar el resultado.

                Reglas:

                Utiliza números decimales

                El método secundario debe ser de tipo double
             */

            try
            {
                Console.WriteLine("Programa para el calculo de potencias usando metodos");
                bool validacion = true;
                string intento = "no";
                do
                {
                    double numero = 0, exponente = 0;

                    Console.WriteLine("Ingrese un numero para calcular la potencia: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el exponente: ");
                    exponente = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine($"El resultado del calculo de la potencia del numero {numero} elevado a la potencia {exponente} es: {calculoPotencia(numero, exponente):N2}");

                    Console.WriteLine("Quieres ejecutar otro calculo, ingrese si o no");

                    intento = Console.ReadLine().ToLower();

                    if(intento == "si")
                    {
                        validacion = true;
                    }
                    else
                    {
                        validacion = false;
                    }
                    
                } while (validacion);


            }
            catch (Exception error)
            {
                Console.WriteLine("Error en la ejecucíón del programa, dato invalido: {0}", error);
               
            }
          

            Console.WriteLine("Fin del programa");
            Console.ReadKey();


        }

        static double calculoPotencia(double numero, double exponente)
        {
            double potencia;

            potencia = Math.Pow(numero,exponente);

            return potencia;
        }


    }
}
