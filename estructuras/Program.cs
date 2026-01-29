using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras
{
    internal class Program
    {
        public struct Agenda//declaracion de la estructur
        {
            public String nombre;
            public String telefono;
            public int edad;

            //sobreescribir metodo tostring()
            public override string ToString()//permite modificar el comportamiento del metodo en funcion de la necesidad del programa, no requiere parametro y devuelve un objeto dle tipo string
            {

                StringBuilder sbcadena = new StringBuilder();//es una clase que provee .net permite crear cadenas de forma eficiente, se puede usar en lugar de concatenacion, permite agregar información especial, permite colocar lista de variables

                sbcadena.AppendFormat($"Nombre {nombre}, edad: {edad}, telefono: {telefono}"); //se usa para poder concatenar dentro de la misma clase del StringBuilder, se puede agregar una cadena de formato personalizada, se le puede dar formato especial a la cadena
                //esta sentencia permite darle formato a una cadena

                return (sbcadena.ToString());//retorna la nueva subcadena
            }


        }
        static void Main(string[] args)
        {
            /*ESTRUCTURAS: */

            Agenda[] amigos = new Agenda[5];//instanciamos una nueva estructura
            //Agregamos información a la estructura en cada uno de sus campos
            amigos[0].edad = 25;
            amigos[0].nombre = "alex";
            amigos[0].telefono = "+573001234567";

            Console.WriteLine( amigos[0].ToString());//aqui mostramos la cadena en el formato indicado en el StringBuilder
            Console.ReadKey();
        }
    }
}

/*
 Estructuras: se componen de muchos arreglos, se puede administrar mejor el orden

Las estructuras son tipos definidos por el programador y son un conjunto de datos agrupados. funcionan como un array o parecido a las colecciones

permiten flexibilidad al almacenar datos

Cuando creamos una estructura, definimos un nuevo tipo y adentro de este tipo podremos colocar datos. Estos datos se conocen como campos

cada campo esta representado por una variable, que puede ser de cualquier tipo

Luego que hemos terminado de definir la estructura podemos crear variables de esta estructura y guardar la información que necesitamos en ellas

se puede manejar como un arreglo pero ahi que tener presente los datos que se deben almacenar

ejemplo:
Agenda telefonica:
    nombre: string
    direccion: string
    telefono: string
    edad: int

Definir una estructura:

para definir una estructura debemos usar 3 pasos:

1. el acceso: indica si la estructura puede verse por fuera del ámbito donde ha sido definida o no. Si el acceso es de tipo publico, se puede acceder a la estructura por afuera del ambito. Para esto pondremos como acceso public. Si no deseamos que el exterior pueda acceder a la estructura, entonces la colocamos como privada. Para esto colocamos el acceso como private.

2. para definir una estructura: Para indicar que definimos una estructura usamos struct seguido del nombre de la estructura. Este puede ser cualquier nombre válido en C#. No hay que confundir el nombre de la estructura con la o las variables que usaremos de ella.

3. Crear bloque de código: Dentro de este bloque definiremos los campos que necesitamos. Estos se definen igual que las variables, pero es necesario colocar el acceso.

--------------------------------------
ejemplo declaracion:

public struct Agenda{

    public String Nombre;
    public int Edad;
    public String Telefono;


}

-------------------------------------

Crear una varible del nuevo tipo:

para definir la variable solo deberemos poner el nombre del tipo seguido del nombre que le daremos a nuestra variable

        ejemplo:
                        Agenda amigo;

podemos crear un arreglo de la estructura. Este arreglo puede ser del tamaño que necesitemos para nuestra aplicación

    Ejemplo:
                        Agenda [] amigos = new Agenda[15];
                        Agenda [] clientes = new Agenda[5];

--------------------------------
Acceder a los campos de la estructura:

Para tener acceso a los campos para poder guardar, leer o modificar los datos primero debemos indicar cual es la variable con la que deseamos trabajar. Luego necesitamos utilizar el operador punto y seguido de el colocamos el nombre del campo a acceder

ejemplo:

variableEstructura.Campo

amigo.Edad = 25;
-----------------------------------------
Mostrar los campos de la estructura

la forma de mostrar todos los datos contenidos en los campos es mediante la conversión de la estructura a una cadena.

usamos el metodo llamado ToString()

C# no se lo puede dar directamente a nuestra estructura porque no puede saber cuales son los campos que contiene ni como los deseamos mostrar.

Debemos programar el metodo ToString() de nuestra estructura
------------------------------------------------------------

























 */
