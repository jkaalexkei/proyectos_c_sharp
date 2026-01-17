using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLogicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
      


            //****************ESTRUCTURA DE CONTROL SWITCH********************************************************
            //La switch instrucción selecciona una lista de instrucciones para ejecutarse en función de una coincidencia de patrón con una expresión de coincidencia,
            //EJERCICIO: Aplicación para operaciones matematicas

            //float a, b, r;
            //int opcion;

            //Console.WriteLine("Seleccione una opcion dependiente de la operación: ");
            //Console.WriteLine("1 Suma");
            //Console.WriteLine("2 resta");
            //Console.WriteLine("3 multiplicación");
            //Console.WriteLine("4 división");
            ////pedimos al usuario que ingrese una opción
            //Console.Write("Escriba una opción: ");
            //opcion = Convert.ToInt32(Console.ReadLine());
            //switch (opcion)
            //{
            //    case 1:
            //        Console.WriteLine("La operación seleccionada es Suma");
            //        break;
            //    case 2:
            //        Console.WriteLine("La operación seleccionada es Resta");
            //        break;
            //    case 3:
            //        Console.WriteLine("La operación seleccionada es Multiplicación");
            //        break;
            //    case 4:
            //        Console.WriteLine("La operación seleccionada es División");
            //        break ;
            //    default:
            //        Console.WriteLine("La opción marcada no se encuentra en el menú");
            //        Console.WriteLine("Fin del programa");
            //        return; 
            //}
            ////capturamos por pantalla los valores a procesar.
            ////para convertir un numero a flotante se utiliza convert.toSingle(Console.ReadLine());
            //Console.WriteLine("Ingrese los numeros a procesar: ");
            //Console.Write("Ingrese primer numero: ");
            //string val_a = Console.ReadLine();//capturamos el primer valor ingresado por el usuario para validar
            //if(float.TryParse(val_a, out a))//esto permite validar si el dato ingresado es valido 
            //{
            //    Console.WriteLine("Primer número ingresado es valido, puedes continuar con el numero 2");
            //}
            //else
            //{
            //    Console.WriteLine("El número es inválido,fin de programa");
            //    return;

            //}
            //Console.Write("Ingrese segundo número: ");
            //string val_b = Console.ReadLine();
            //if (float.TryParse(val_b, out b))
            //{
            //    if(b != 0) { 
            //        Console.WriteLine("No se puede dividir un numero entre cero");
            //        return;
            //    }
            //    else { 
            //        Console.WriteLine("El número ingresado es valido, el resultado de la operación es: ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("El numero ingresado no es valido, fin del programa");
            //    return;
            //}
            //Console.WriteLine($"Los valores ingresados son {a} y {b}");
            //    switch (opcion)//dentro de los parentesis va la opcion o condicion a evaluar
            //    {
            //        case 1:
            //            Console.WriteLine($"La suma de los números {a} + {b} es: {a + b}");
            //            Console.WriteLine("Fin del programa");
            //            break;

            //        case 2:
            //            Console.WriteLine($"La resta de los números {a} - {b} es: {a - b}");
            //            Console.WriteLine("Fin del programa");
            //            break;
            //        case 3:
            //            Console.WriteLine($"La multiplicación de los números {a} * {b} es: {a * b}");
            //            Console.WriteLine("Fin del programa");
            //            break;
            //        case 4:
            //            Console.WriteLine($"La división de los números {a} / {b} es: {a / b}");
            //            Console.WriteLine("Fin del programa");
            //            break;

            //    }











            //************************************************************************
            //ejercicio para validar si usuario puede conducir, tomar en cuenta la edad mayor a 15, que tenga licencia y auto






            //********************************************************************

            //int numero = 10;

            ////si un if no tiene if anidados se puede escribir sin las llaves de cierre
            //if (numero < 5)
            //    Console.WriteLine("El numero es menor que 5");
            //else
            //    Console.WriteLine($"El numero {numero} es mayor que 5");


            //*********************************************************************
            //EXPRESIONES LOGICAS NEGACIÓN

            // ! operador negación --> el operando del lado derecho es true, el operador regresa false. Y si el operando del lado derecho es false, el operador regresa true

            //bool verdadero = true;
            //Console.WriteLine(verdadero);//imprime true
            //Console.WriteLine(!verdadero);//imprime false
            //Console.WriteLine(verdadero);
            //if (!verdadero)//quiere decir si no es verdadera la condicion
            //{
            //    Console.WriteLine("La variable es falsa");
            //}
            //else
            //{
            //    Console.WriteLine("La variable es verdadera");
            //}

            // && condicion Y se deben cumplir las dos condiciones
            // || condicion O se debe cumplir al menos una de las dos condiciones

            //bool lluvia = true;
            //bool sol = false;

            //if (lluvia == false || sol == true)
            //{
            //    Console.WriteLine("Esta lloviendo, usar sombrilla");
            //}
            //else
            //{
            //    Console.WriteLine("Hay buen tiempo");
            //}




        }
    }
}
