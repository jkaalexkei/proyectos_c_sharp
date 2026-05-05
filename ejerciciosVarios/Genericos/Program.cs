using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instanciamos la clase
            AlmacenaObjetos archivos = new AlmacenaObjetos(4);
            archivos.agregarObjetos("Hola");
            archivos.agregarObjetos(DateTime.Now);
            archivos.agregarObjetos(123);
            archivos.agregarObjetos(true);

            Console.WriteLine(archivos.getObtenerObjeto(1));

        }
    }

    //crear clase para almacenar distintos tipos de objetos
    class AlmacenaObjetos
    {
        private Object[] datosElemento;//se declara un array de tipo Object para que almacene objetos de cualquier tipo
        private int i = 0;//contador para inicializar el array

        public AlmacenaObjetos(int z)//el parametro se utiliza para especificar la cantidad de objetos que guardara el array
        {
            //inicializamos el array
            datosElemento = new Object[z];//instanciamos e indicamos la cantidad de objetos que tendra el array de objetos
        }

        //metodo agregar elementos

        public void agregarObjetos(Object objeto)//agregar objetos al array de objetos, recibe un objeto como parametro
        {
            datosElemento[i] = objeto; //aqui le pasamos el objeto al array en la posición de i = 0 (posición 0 del array)
            i++;//incrementamos el valor
        }

        //metodo obtener elementos

        public Object getObtenerObjeto(int i)//Obtiene el objeto, recibe como parametro el valor de i para indicar la posición del array de objeto que queremos devolver. Se declara de tipo objeto porque es el valor que estamos retornando
        {
            return datosElemento[i];//retiornamos el objeto
        }
    }
}

/*
 Genericos
     Es una caracteristica de c#
     principal caractaristica es reutilización de codigo similar a la herencia

    consiste en crear clases comodin que permiten manejar cualquier tipo de objeto
    con genericos se puede crear una unica clase que maneja clases de cualquier tipo

sintaxis:
    ejemploClase<String> archivos = new ejemploClase<string>();

se le indica en la declaración el tipo de dato a la clase entre simbolos de mayor y menor

Usar la herencia para crear clases que sirvan para cualquier tipo de objeto tiene sus inconvenientes:
    
    - uso continuo del casting
    - compilación del código
    - no posibilidad de comprobación de errores

porque se usa la programación?=
-mayor sencilles del codigo
-reutilización del codigo en numeros escenarios
-comprobación de errores en tiempo de compilación (implica que es el propio editor el que mostrara el error en el codigo antes de ejecutar el programa)
-si se utiliza la herencia para ejecutar este tipo de clases hasta que la aplicación no esta en ejecución el error no se manifiesta, para esto se debe detener la ejecución y validar donde se encuentra el error.


en c# todos los objetos heredan de una clase principal llamada Object


Por convención para indentificar una clase generica se coloca entre parentesis angulares o simbolos de menot y mayor una letra T mayuscula como se ve a continuación <T> 

 
 
 
 
 
 
 
 
 
 
 */