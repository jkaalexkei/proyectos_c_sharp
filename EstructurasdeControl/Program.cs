using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EstructurasdeControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ingrese primer Numero: ");
            //decimal numero1 = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Ingrese segundo numero: ");
            //decimal numero2 = Convert.ToDecimal(Console.ReadLine());
            //try {
            //    if (numero1 != 0 || numero2 !=0)
            //    {
            //        decimal resultado = numero1 / numero2;
            //        Console.WriteLine("El resultado de la división es: ",resultado);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Los números son incorrectos");
            //        return;
            //    }
            //}
            //catch (Exception error) {
            //    Console.WriteLine(error);
            //}
            //Console.ReadKey();

            /*Ejercicio Switch 3: Notas estudiante
            Crea un programa que tome una nota numérica como entrada(0 - 100) y muestre una calificación correspondiente(A, B, C, D, F) utilizando un switch case.



            Reglas:

                        Enunciado: Entre 90 y 100: A, entre 80 y 89: B, entre 70 y 79: C, entre 60 y 69: D, menor a 59: F

                        El programa debe mostrar un mensaje por pantalla indicando error si el usuario ingresa un número mayor a 100

            Usa diferentes estructuras
            int nota;
            Console.WriteLine("validar literal de la calidación");
            Console.WriteLine("Ingerse una calificación");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("Calificación fuera de rango");
            }
            else
            {
                nota = nota / 10;

                switch (nota)
                {
                    case 10:
                        Console.WriteLine("Corresponde a Literal A");
                        break;
                    case 9:
                        Console.WriteLine("Corresponde a Literal A");
                        break;
                    case 8:
                        Console.WriteLine("Corresponde a Literal B");
                        break;
                    case 7:
                        Console.WriteLine("Corresponde a Literal C");
                        break;
                    case 6:
                        Console.WriteLine("Corresponde a Literal D");
                        break;
                    case 5:
                        Console.WriteLine("Corresponde a Literal E");
                        break;
                    default:
                        Console.WriteLine("Corresponde a Literal F");
                        break;
                    
                }
            }*/

            //            Ejercicio integrado(Conjunción y Disyunción): Validación de usuario VIP
            //Crea un ejercicio que valide los siguientes datos ingresados por un usuario:

            //*Monto de una factura

            //* VIP

            //Para que pueda ingresar a la zona de clientes especiales



            //Reglas:

            //            Para acceder a la zona de clientes se debe cumplir una de los dos condiciones: Factura mayor a 100 o ser cliente VIP

            //Respuesta del cliente a escoger: 1 = si y 0 = no

            //El ejercicio debe llevar if anidado y validaciones AND y OR

            //Respeta la ley de la lógica

            //El ejercicio debe imprimir por pantalla si el usuario ingresa un número diferente a 0 o 1

            //Imprimir por pantalla si accede, no accede o si ingreso un número diferente

            //            int montoFactura, clienteVip;

            //            Console.WriteLine("Para zona de clientes VIP ingresa lo siguiente: ");
            //            Console.WriteLine("Ingrese el monto de la factura");
            //            montoFactura = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Ingrese si eres cliente VIP: 1=SI y 0=NO");
            //            clienteVip = Convert.ToInt32(Console.ReadLine());
            //            if (clienteVip != 1 || clienteVip != 0)
            //            {
            //                Console.WriteLine("Haz ingresado un dato erroneo, fin del programa");
            //            }
            //            else
            //            {
            //                if (montoFactura >= 100 && clienteVip == 1)
            //                {
            //                    Console.WriteLine("Puedes ingresar a la zona de clientes VIP");
            //                }
            //                else if (montoFactura >= 100 || clienteVip == 1)
            //                {
            //                    Console.WriteLine("Puedes ingresar a zona de clientes");
            //                }
            //                else if (montoFactura < 100 && clienteVip == 0)
            //                {
            //                    Console.WriteLine("No puedes ingresar a la zona de clientes");
            //                }

            //                else
            //                {
            //                    Console.WriteLine("Los datos ingresados son erroneos");
            //                }

            //            }




            /* Try Catch
             * cuando se presenta un error al momento de ingresar datos, la aplicación se va a detener. Esta estructura nos va a permitir mostrar el error avisandole al usuario que ingreso un forma no valido
             Estructura de control 
            try{
            codigo a ejecutar
            }
            catch(excepción "tipo de variables de excepcion"){
                codigo a ejecutar - error

            }
             */

            //try
            //{
            //    int n1, n2, resul;
            //    Console.Write("Ingrese primer numero: ");
            //    n1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Ingrese el segundo numero: ");
            //    n2 = Convert.ToInt32(Console.ReadLine());

            //    resul = n1 * n2;
            //    Console.WriteLine("el resultado es: ", resul);
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error);//nos muestra la cadena que indica el tipo de error que se esta generando
            //}

            //int rangoInicio, rangoFin,numero;

            //numero = 51;

            //rangoInicio = 10;
            //rangoFin = 50;

            //if (numero >= rangoInicio && numero <= rangoFin)
            //{
            //    Console.WriteLine("El numero {0} esta dentro del rango",numero);
            //}
            //else
            //{
            //    Console.WriteLine("El numero esta fuera del rango");
            //}





        }
    }
}
