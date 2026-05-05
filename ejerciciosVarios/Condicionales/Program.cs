using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////menu de opciones
            //Console.WriteLine("MENU DE OPCIONES \n" +
            //    "1.- Sumar dos numeros \n" +
            //    "2.- Restar 2 numeros \n " +
            //    "3.- Multiplicar 2 numeros \n" +
            //    "4.- Salir");


            //Console.WriteLine("Ingrese una opcion: ");
            //int opcion = int.Parse(Console.ReadLine());
            //switch (opcion)
            //{
            //    case 1:
            //        Console.WriteLine($"opcion Suma");
            //        Console.WriteLine("Ingrese numero 1: ");
            //        int n1 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese numero 2: ");
            //        int n2 = int.Parse(Console.ReadLine());
            //        int suma = n1 + n2;
            //        Console.WriteLine($"El resultado de la suma es: {suma}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"opcion Resta");
            //        Console.WriteLine("Ingrese numero 1: ");
            //        int r1 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese numero 2: ");
            //        int r2 = int.Parse(Console.ReadLine());
            //        int resta = r1 - r2;
            //        Console.WriteLine($"El resultado de la resta es: {resta}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"opcion Multiplicación");
            //        Console.WriteLine("Ingrese numero 1: ");
            //        int m1 = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese numero 2: ");
            //        int m2 = int.Parse(Console.ReadLine());
            //        int multiplicacion = m1 * m2;
            //        Console.WriteLine($"El resultado de la multiplicación es: {multiplicacion}");
            //        break;
            //    case 4:
            //        Console.WriteLine("Fin del programa");
            //        break;
            //    default:
            //        Console.WriteLine("No existe esa opción");
            //        break;

            //}

            
            
            //validar numero par,multiplo de 5 o ambos, en este tipo de ejercicio la condicion mas especifica va de primero

            //Console.WriteLine("Ingrese un numero entero");
            //int numero = Convert.ToInt32(Console.ReadLine());

            //if ((numero % 2 == 0) && (numero % 5 == 0))
            //{
            //    Console.WriteLine("el numero es par y multiplo de 5");

            //}else if (numero % 2 == 0)
            //{
            //    Console.WriteLine("El numero es par");
            //}
            //else if (numero % 5 == 0)
            //{
            //    Console.WriteLine("Es multiplo de 5");
            //}
            //else if(numero % 2 != 0)
            //{
            //    Console.WriteLine("Es impar");
            //}
            //else
            //{
            //    Console.WriteLine("No contemplado");
            //}


            //clasificación de notas
            //Console.WriteLine("Igresa una calificación entre 0 y 100");
            //int nota = Int32.Parse(Console.ReadLine());
            //if (nota >= 90 && nota <= 100)
            //{
            //    Console.WriteLine("Excelente");
            //}
            //else if (nota >= 70 && nota <= 89)
            //{
            //    Console.WriteLine("Bueno");
            //}
            //else if (nota >= 50 && nota <= 69)
            //{
            //    Console.WriteLine("Regular");
            //}
            //else if (nota >0 && nota < 50)
            //{
            //    Console.WriteLine("Reprobado");
            //}
            //else if (nota < 0)
            //{
            //    Console.WriteLine("No se permiten notas negativas");
            //}
            //else { 
            //    Console.WriteLine("El numero es invalido, fuera del rago");
            //}


            //validar mayoria de edad
            //Console.WriteLine("Mayoria de edad");
            //int edad = Int32.Parse(Console.ReadLine());
            //if (edad >= 18)
            //{
            //    Console.WriteLine("Eres mayor de edad");
            //}
            //else
            //{
            //    Console.WriteLine("Eres menor de edad");
            //}
            
            //Número positivo, negativo o cero
            //Console.WriteLine("Ingresa Numero Validar si es positivo, negativo o cero");
            //int numero = Int32.Parse(Console.ReadLine());

            //if (numero < 0)
            //{
            //    Console.WriteLine("El numero es negativo");
            //}else if(numero > 0)
            //{
            //    Console.WriteLine("El numero es positivo");
            //}
            //else
            //{
            //    Console.WriteLine("El numero es cero");
            //}
        }
    }
}
