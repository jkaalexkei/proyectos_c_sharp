using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            mensajeEnPantalla();
            Console.WriteLine("Mensaje desde el Main");
            Console.WriteLine(sumaNumerosDos(2, 2));
            Console.WriteLine(divideNumeros(2, 2));
            Console.ReadKey();
        }

        static void mensajeEnPantalla()//este tipo de metodo no retorna valores
        {
            Console.WriteLine("Mensaje desde el metodo mensajeEnPatalla()");
        }

        static void sumaNumeros(int n1, int n2)//este metodo recibe parametros pero no retorna valor
        {
            int suma = n1 + n2;
            Console.WriteLine(suma);
        }
        static int sumaNumerosDos(int n1, int n2)//este metodo retorna valor y recibe dos parametros
        {
            int suma = n1 + n2;

            return suma;
        }
        static int divideNumeros(int n1, int n2) => n1 + n2;//este metodo de una sola linea retorna valor de tipo entero


        



    }
}


/*
             * 
             * todos los metodos iran dentro de una clase
             * se debe especificar el tipo devuelto y los parametros
             * no hay distinción entre metodos y funciones, en c# ambos terminos es lo mismo
             * un metodo se puede llamar N veces
             * los parametros se pueden pasar por valor o referencia
             * hay que tener en cuenta el tipo de dato que debera devolver el metodo
             * una operacion entre un double y un int el resultado siempre sera un double
             * el valor retornado de la funcion debe ser del mismo tipo declarado de la funcion
             * cuando el metodo tiene una sola linea de codigo las llaves de apertura y cierre se pueden reemplazar por el operador =>
             
            Metodos:
            grupos de instrucciones a las que se da un nombre identificativo que realizan una tarea en concreto

            sirven para realizar una tarea en concreto, este no se ejecuta hasta que no es llamado

            sintaxis            
            
            int,string,float

            ejemplo

             tipodevuelto nombreMetodo(){
                
                codigo a ejecutar (cuerpo del metodo)
                
                return valordevuelto

            }

            tipodevuelto nombreMetodo(parametros){
                
                codigo a ejecutar (cuerpo del metodo)
                
                return valordevuelto

            }

            cuando se especifica el tipo de dato en la funcion dentro del codigo de la funcion debe ir un return que devuelva el tipo de dato declarado en el nombre de la funcion  
             
             ejemplo para practicar, hacer un codigo que simule el funcionamiento de una maquina de bendi

            un metodo con la palabra reservada void no retorna o devuelve valores y no lleva un return

            ejemplo

            void sumaNumeros(){

                int n1=2;
                int n2=2;
                int suma = n1 + n2;
                Console.WriteLine(suma);

            }

AMBITO:
El ambito o alcance del metodo solo es accesible dentro de las llaves de apertura y cierre del metodo, ambito local

variable o constante de clase tambien se denominan campos de clases

SOBRECARGA DE METODO

cuando en el mismo ambito o clase 2 o mas metodo con el mismo nombre

son metodos que reciben el mismo nombre pero diferente cantidiad de parametros.





































             
             */