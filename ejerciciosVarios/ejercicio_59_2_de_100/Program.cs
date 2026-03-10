using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_59_2_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hacer un programa que simule una calculadore cientifica
            bool val = true;
            int numero, opcion;
            string comprobacion;
            string[] operaciones = { "Raiz Cuadrada", "Valor Absoluto", "Seno", "Coseno", "Potencia","tabla de multiplicar" };
            
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Clear();
                Console.WriteLine("Numero a procesar es: {0}",numero);
                Console.WriteLine("Seleccione una operación de las disponibles: ");
                for (int i = 0; i < operaciones.Length;i++)
                {
                    Console.Write($"| {i} - {operaciones[i]} ");
                }
                Console.WriteLine();

                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine($"Seleccionaste la operacion {operaciones[opcion]}");
                        Console.WriteLine($"la {operaciones[opcion]} es {Math.Sqrt(numero)}");
                        break;
                    case 1:
                        Console.WriteLine($"Seleccionaste la operacion {operaciones[opcion]}");
                        Console.WriteLine($"El {operaciones[opcion]} es {Math.Abs(numero)}");
                        break;
                    case 2:
                        Console.WriteLine($"Seleccionaste la operacion {operaciones[opcion]}");
                        Console.WriteLine($"El {operaciones[opcion]} es {Math.Sin((numero * Math.PI) / 180)}");
                        break;
                    case 3:
                        Console.WriteLine($"Seleccionaste la operacion {operaciones[opcion]}");
                        Console.WriteLine($"El {operaciones[opcion]} es {Math.Cos((numero * Math.PI) / 180)}");
                        break;
                    case 4:
                        Console.WriteLine($"Seleccionaste la operacion {operaciones[opcion]}");
                        Console.WriteLine($"La {operaciones[opcion]} al cuadrado de {numero} es {Math.Pow(numero,2)} ");
                        break;
                    case 5:
                        Console.WriteLine($"Seleccionaste la operación {operaciones[opcion]} del numero {numero}");
                        for (int j = 0; j <= 10; j++)
                        {
                            Console.WriteLine($"{j} x {numero} = {j * numero}");
                        }
                        break;
                    default:
                        Console.WriteLine("La opción no esta contemplada");
                        break;
                }

                Console.WriteLine("Desea realizar otra operación");
                comprobacion = Console.ReadLine().ToLower();
                
                if (comprobacion == "si")
                {
                    Console.WriteLine("Quieres seguir con el mismo numero: ");
                    string reintento = Console.ReadLine().ToLower();

                    if (reintento == "si")
                    {
                        Console.WriteLine("Continua con los calculos");
                    }
                    else
                    {
                        
                        Console.WriteLine("Ingrese el nuevo numero: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                    }

                }
                else
                {
                    val = false;
                }

                
               
                       

                
            }
            while (val);
            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
