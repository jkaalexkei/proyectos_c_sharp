using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosyFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Elija una opción: ");
            Console.WriteLine("1.suma, 2.resta,3.multiplicacion,4.division");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Haz elegido sumar");
                Suma();//llamado a la funcion o metodo
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Elejiste Resta");
                float resultado = 0;//declaramos una variable para almacenar el valor que devuelve la funcion Resta()
                resultado = Resta();//lo que retorna la funciona Resta() lo almacenamos en la variable resultado
                Console.WriteLine("El resultado de la resta es : {0}", resultado);
                Console.WriteLine("Fin del programa)");
                /*en este tipo de ejemplos, el mensajes de resultados siempre van aca donde se hace el llamado a la función y no en la funcion donde se hace el proceso.*/
                
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Elejiste Multiplicación");
                float n1, n2;
                Console.Write("Ingrese el numero 1: ");
                n1 = Convert.ToSingle(Console.ReadLine());
                Console.Write("Ingrese el numero 2: ");
                n2 = Convert.ToSingle(Console.ReadLine());

                Multiplicacion(n1,n2);

            }
            else if (opcion == 4)
            {
                Console.WriteLine("Elejiste división");
                float a, b, resultado = 0;
                Console.Write("Ingresa primer numero: ");
                a = Convert.ToSingle(Console.ReadLine());
                //Console.Write("Ingrese el segundo numero: ");
                do
                {
                    Console.Write("Ingrese el segundo numero: ");
                    b = Convert.ToSingle(Console.ReadLine());
                    if (b==0)
                    {
                        Console.WriteLine("No se puede dividir por cero");
                    }

                } while (b == 0);
                resultado = Division(a, b);
                Console.WriteLine("El resultado de la división es: {0}", resultado);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("La opcion no esta contemplada");
            }
            Console.ReadKey();
        }

        static void Suma()
        {
            float a, b; //estas son variables locales y solo se pueden usar dentro del metodo o funcion donde se declararon
            float r = 0;
            Console.Write("Ingresa el valor de a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el valor de b: ");
            b = Convert.ToSingle(Console.ReadLine());

            r = a + b;

            Console.WriteLine("El resultado es {0}", r);
            Console.WriteLine("Fin de la operación");
            Console.ReadKey();
        }

        static float Resta()//cuando el metodo o funcion cuenta  con el tipo de dato de dato que regresara se debe colocar el return con el valor a retornar.
        {
            float a, b; //estas son variables locales y solo se pueden usar dentro del metodo o funcion donde se declararon
            float r = 0;
            Console.Write("Ingresa el valor de a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("Ingrese el valor de b: ");
            b = Convert.ToSingle(Console.ReadLine());

            r = a - b;

            return r;
        }

        static void Multiplicacion(float a, float b)
        {
            float r = 0;
            r = a * b;
            Console.WriteLine("El resultado de la multiplicación es {0}", r);
        }

        static float Division(float a, float b)
        {
            float r = 0;
            r = a / b;

            return r;
        }

    }
}
