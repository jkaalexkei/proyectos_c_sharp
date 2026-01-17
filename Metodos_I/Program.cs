using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_I
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           //Console.WriteLine(restaNumeros(9, 7));
            
        }

        void primerMetodo()
        {
            int numero1 = 5;
        }

        void segundMetodo()
        {
            Console.WriteLine(numero1);
        }





        //el texto de abajo se refiere a que el metodo se ha llamado 1 vez
        //static void sumaNumeros(int a, int b)
        //{
        //   //este tipo de metodo no devuelve valores
        //}

        //static int restaNumeros(int n1,int n2)
        //{
        //    //int resta = n1 - n2;
        //    //return resta;
        //}


    }
}


/*Que son: grupo de sentencias a las que se da un nombre identificativo que realizan una tarea en concreto

            para que sirve: para ejecutar una tarea en concreto en un momento determinado, un metodo no realiza su tarea hasta que no es llamado

            sintaxis
               tipodedatodevuelto nombredelmetodo (parametros){
                       cuerpo del metodo

                       return; --> para el valor que queremos devolver el metodo
               }

           consideraciones
               no se ejecuta hasta que se llame
               todos los metodo iran dentro de una clase
               se debe especificar el tipo devuelto y los parametrosn (en caso de tenerlos)
               no hay distinción entre la palabra metodo o función, en C# ambos terminos son lo mismo
               si el metodo tiene la palabra reservada void este no devuelve ningun dato (lo que hace es imprimir)
               si el metodo cuenta con el tipo de dato, el metodo debe llevar la palabra reservada return;
               si se omiten estas consideraciones puede dar error en la compilación
            */
/*
metodos de tipo void---> son aquellos metodos que no devuelven datos
Apuntes:
todo programa en c# debe llevar el metodo Main, no devuelve ningun dato, este metodo recibe un metodo string de tipo array y unos args (argumentos)
la palabra reservada static implica que es un metodo que pertenece a la clase, no se debe utilizar ningun objeto en la llamada
el metodo main es el punto de entrada, el programa siempre va a iniciar la ejecución desde este metodo
debe ser estatico porque como es el punto de entrada no hay objetos creados este metodo main debe ser llamado sin necesidad de tener objetos creados

el texto que dice arriba de la función con la palabra referencia se refiere a las veces que se ha llamado la función

en cuanto a parametros: puede recibir parametros de diferentes tipos de dato
en un metodo que recibe parametros, al momento de llamar el metodo hay que pasarle los parametros correspondientes y estos deben ser del mismo tipo de dato.
a la hora de pasar parametros se puede hacer de dos formas: por valor y por referencia.

-------------------------------------------------------------------------------------------------------

Metodos que devuelven valores:
se debe especificar el metodo con un tipo de dato especifico
se debe obligatoriamente escribir la palabra reservada return
cuando se consigue un return el flujo de ejecución devuelve el flujo de ejecucion a la llamada.
la operacion matematica entre un double y un int el resultado devolvera un double
se debe mantener la coherencia de los datos

cuando el metodo tiene una sola linea de codigo se pueden prescindir de las llaves y se puede usar el operador => y del lado derecho el valor que retornara el metodo

+++++++++++++++++++++++++++++++++++++++++++++++++++++
Ambito o alcance: 
    es todo el codigo que se encuentra entre las llaves de apertura y cierre y las variables y funciones seran visibles solo dentro de ese ambito

una vez que finaliza la ejecución del metodo, toda la ejecucion queda fuera de la memoria
variable de ambito local es la que solo se puede usar dentro de las llaves de apertura y cierre del metodo
para poder usar variables dentro de un metodo estas deben ser declaradas al inicio del metodo





 */

