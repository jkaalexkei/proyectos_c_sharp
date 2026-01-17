using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach
            /*
             El bucle foreach en C# es una estructura de control que se utiliza para iterar sobre cada elemento de una colección (como un array o una lista) sin necesidad de manejar un índice manualmente. Su sintaxis es más simple y legible que la de un bucle for tradicional, ya que itera automáticamente sobre los elementos hasta que no quedan más por procesar. 
             
             */
            /*
             char --> La variable char en C# almacena un único carácter Unicode de 16 bits, como una letra, número o símbolo. Los valores se escriben entre comillas simples, como 'A' o '5', y el tipo char es un tipo de valor integral de C#. Se puede utilizar para almacenar datos de un solo carácter y se puede convertir implícita o explícitamente a tipos de datos numéricos enteros o de punto flotante. 
             */
            string nombre = "Alexander Varela";
            foreach (char letra in nombre)
            {
                Console.Write($" {letra} ");
            }

            /*++++++++++++++++++++++++++++++++++*/
            //ciclo for
            //inicia con la palabra for
            //entre parentesis la inicialización,condicion,incremento
            //codigo a ejecutar
            //sintaxis
            /*
             for(inicializacion;condicion;incremento){
                    codigo a ejecutar
            }

            el orden de ejecución es:
            1-inicializacion
            2-condicion
            3-codigo
            4-incremento
            si no se cumple la condicion se sale del bucle

             
             
             */
            //calcular el promedio de las calificaciones de 3 alumnos
            //float n1, n2, n3, promedio;
            //pedir datos
            //Console.WriteLine("Ingresa primera calificación");
            //n1 = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Ingresa segunda calificación");
            //n2 = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("Ingresa tercera calificación");
            //n3 = Convert.ToSingle(Console.ReadLine());

            //promedio = (n1 + n2 + n3) / 3;
            //Console.WriteLine($"el promedio es: {promedio}");
            //Console.ReadKey();

            ////**********************************************************
            //ejemplo: mostrar numeros desde 1 al 10
            //int n = 0;
            //Console.WriteLine("Ingrese un numero");
            //int nv = Convert.ToInt32(Console.ReadLine());

            //for (n = nv; n <= 10; n++)//el incremeneto se puede colocar segun la necesidad del codigo, tambien se puede hacer en decremento
            //{
            //    Console.WriteLine(n);
            //}
            //Console.ReadKey();
            //***************************************************
            //int contador = 0;
            //int acumulador = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //    contador = contador + i;
            //    acumulador = acumulador + contador;
            //    Console.WriteLine($"contador {contador}, acumulador {acumulador}");
            //}
            //Console.WriteLine($"Asi quedaron: contador {contador}, acumulador{acumulador}");
            //Console.ReadKey();
            //*********************************************
            //promedio de notas usando un bucle for
            /* float nota = 0.00f;
             int cantidadNotas;
             int contador;
             float notaAcumulada = 0.00f; 
             //solicitamos ingreso de datos:

             try
             {
                 Console.WriteLine("Cuantas Notas desea promediar");
                 cantidadNotas = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Haz ingresado un dato valido {0}",cantidadNotas);
                 for (contador = 0; contador < cantidadNotas; contador++)
                 {
                     Console.WriteLine($"Ingrese la nota {contador+1}");
                     nota = Convert.ToSingle(Console.ReadLine());
                     notaAcumulada = notaAcumulada + nota;

                 }
                 float promedio = notaAcumulada / cantidadNotas;
                 Console.WriteLine("Haz ingresado {0} notas a promediar", cantidadNotas);
                 Console.WriteLine($"se obtuvo un promedio de las {cantidadNotas} notas registras de {promedio}");
             }
             catch (Exception error) {
                 Console.WriteLine($"Haz ingresado un dato invalido descripción: {error}");
             }

             Console.ReadKey();*/

            //***************************
            //calculo de un factorial, recordar que es la multiplicación regresiva del numero indicado hasta el 1
            //datos de entrada
            //int numero;
            //int contador;
            //int factorial = 0;
            //int acumulador = 1;
            ////captura de datos
            //Console.WriteLine("Ingrese el numero a calcular: ");
            //numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("");

            //for (contador = numero;contador >= 1; contador--)
            //{
            //    Console.WriteLine($"{acumulador} x {contador} = {acumulador * contador}");
            //    acumulador = acumulador * contador;
               
                
            //    //Console.WriteLine("Acumulador = {0}", acumulador);
                
                
            //}
            //Console.WriteLine("El factorial de {1} es: {0}", acumulador,numero);
            
            /*
             * 
             *   3 = 3x2x1
             
             for(contador = 3; 3 >= 1; decrementamos el 3){

                    escribimos contador = 3
                    acumulador = 0 * 3
                    



            }
            acumulador = 0

             
             
             
             */

        }

    }
}

