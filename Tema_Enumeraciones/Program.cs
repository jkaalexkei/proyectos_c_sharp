using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_Enumeraciones
{
    internal class Program
    {
        //Declación de enumeraciones
        enum semana { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, domingo }
        enum colores { Rojo = 1, Verde, Azul, Amarillo }

        static void Main(string[] args)
        {
            int numerico = 0;

            //Declaramos variable de tipo semana
            semana miDia;

            //Asignamos un valor a miDia
            miDia = semana.Lunes;

            //Pasamos de enumeración a entero
            numerico = (int)miDia;

            //mostrar información
            Console.WriteLine("El día es {0} con valor {1}", miDia, numerico);

            //crear una variable de tipo color 
            colores miColor = colores.Rojo;

            //pasamos de enumeración a entero 
            numerico = (int)miColor;

            //mostrar información para colores
            Console.WriteLine("El color es {0} con valor {1}", miColor, numerico);

            Console.ReadKey();
        }
    }
}
/*
 
Enumeraciones

• Éstas son tipos que nosotros podemos definir, pero tendrán un número finito de valores posibles, es decir, que podemos definir el tipo y los valores a guardar.

• Las enumeraciones son útiles cuando tenemos información que sabemos que solamente puede tener uno de una serie de posibles valores

Declaración y asignación de valores:

Para declarar una enumeración usamos el siguiente formato:

    enum nombre {valor1, valor2, …, valorn};



 
 */