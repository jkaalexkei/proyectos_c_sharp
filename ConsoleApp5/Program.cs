using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Funciones y Metodos (en c# son iguales);
            /*
             La funcion o metodo se un elemento del programa que contiene codigo y se puede ejecutar, es decirm lleva a cabo una operación (conjunto de instrucciones). La funcion o metodo puede llamarse o invocarse cuando sea necesario y entonces el código que se encuentra en su intrior se va a ejecutar. Una vez que la funcion termina de ejecutarse el programa continua en la sentencia siguiente de donde fue llamada
             */

            /*

             static void Maing(string[] args){

                codigo a ejecutar

                }

                todos los metodos deben estan dentro de una clase en c#

                 ejemplo (Clase.metodo) )Convert.toInt32();

                Funciones y metodos

                estos constan de cinco partes
                modificador   tipo  nombre  (parametros){
                        codigo a ejecutar
                }

                pueden regresar cadenas, flotantes, enteros, otros;

                static -> modificador
                tipo -> informacion que va a regresar el metodo por ejemplo void (vacio), esta relacionado al tipo de dato que retornara la funciona
                nombre -> nombre de la funcion o metodo, debe ser unico, la llamada se hace mediante el nombre.
                parametros -> lista de variables que reciben los datos que se procesan en el metodo, nosotros como usuarios le proporcionamos información al metodo a traves de los parametros
                codigo-> se ubica dentro del bloque que abarque el metodo

             tipos de metodos:
            ejecutan solo codigo-> no reciben datos y no regresan ningun valor, se deben declarar para usarlos dentro de una clase
            ----------------------------------------------------------------------------------------------------------------------
            reciben parametro  -> Un método que recibe parámetros en C# es un bloque de código que puede aceptar valores externos para realizar una tarea. Estos valores, llamados argumentos, se pasan al método cuando se le llama y se almacenan en variables llamadas parámetros, definidas dentro de los paréntesis en la declaración del método. Los parámetros permiten que un mismo método realice diferentes operaciones según los datos que se le pasen, lo que lo hace más flexible y reutilizable. 

                recibe valores en los parametros que son procesados en el codigo y los resultados son devueltos a traves de un return
------------------------------------------------------------------------------------------------------------------------------------
            regresan valores -> Un método que regresa valores en C# es una función que devuelve un resultado al código que la llama utilizando la palabra clave return. En lugar de void en la declaración, se especifica el tipo de dato del valor que se retornará (como int, string, bool, etc.). La ejecución del método termina en la instrucción return y el valor especificado se envía de vuelta al lugar donde fue invocado, para poder ser asignado a una variable o utilizado directamente en una expresión. 

            en la zona de parametros se deben declarar usando el tipo de dato y el nombre de la variable a usar
       -----------------------------------------------------------------------------------------------------------------------------

            regresan valores y parametros-> Un método en C# que recibe valores y parámetros es un bloque de código reutilizable que puede aceptar datos de entrada a través de sus parámetros, realizar operaciones con ellos y opcionalmente devolver un resultado. Los parámetros son variables declaradas en la firma del método que actúan como marcadores de posición para los valores que se le pasan cuando se le invoca (los argumentos). Esto permite que el método sea más flexible, reutilizable y capaz de operar con diferentes datos. 

            - recibe la informacion cuando se invoca
            - la información sera pasada por medio de los parametros
            - el metodo llevara alguna accion o calculo y va ha obtener un valor que va a ser regresado
            - ese valor regresado es recibido en el lugar donde se invoco el metodo para trabajr con el
            - los parametros sera usados como variables y se deben declarar dentro de los parentesis
            -tambien se debe indicar el tipo que se va a recibir es decir no sera vacio (void) sino va a ser un tipo de dato diferente a ese metodo (int,, float, string, otros)
            - como el metodo va a regresar un valor es necesario indicar ese tipo en la declaración
            -la variable que va a recibir el valor retornado debera tener el mismo tipo que en el metodo



             */
        }
    }
}
