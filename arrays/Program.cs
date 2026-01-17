using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] edades;
            //edades = new int[4];

            //edades[0] = 1;
            //edades[1] = 2;
            //edades[2] = 3;
            //edades[3] = 4;
            Console.WriteLine("Ingrese las edades a registrar");
            int e = Convert.ToInt32(Console.ReadLine());

            int[] edades = new int[e];

            for (int i = 0; i < edades.Length;i++)
            {
                Console.Write($"Edad {i}: ");
                edades[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Edades registradas: ");
            for (int j = 0; j < edades.Length;j++)
            {
                Console.WriteLine(edades[j]);

            }

        }
    }
}
/*
 Arrays
        Es una estructura de datos que contiene una colección de valores del mismo tipo

Para que se usan:
        Para almacenar valores que normalmente tienen alguna relación entre si.

sintaxis
        tipodedato[] nombreArray = new tipodato[longitud]
        int[] mi_matriz = new int[4]

 
 sino se le dan valores al array toma el valor por defecto que es 0

 errores comunes:
    intentar acceder a una posición que no existe. (Excepción no controlada: System.IndexOutOfRangeException: Índice fuera de los límites de la matriz.)

 
 arrays implicitos:
    un array que almacena datos, no se especifica el tipo de dato ni la cantidad de elementos que almacenara

    declaracion

            var datos = new []{"alex","varela","tovar"};

            var valores = new[]{15,25,65.3,30.30} -> en este caso c# le asigna a este array como tipo de dato double

arrays de objetos:

            contiene objetos

                Clase [] nombreArray = new nombreClase[];

                nombreArray[0] = new nombreClase(parametros de la clase);
                
                Empleados [] arrayEmpleados = new Empleados[2];

                arrayEmpleados[0] = new Empleados("alex",42);

arrays clases anonimas:

declaracion


    var personas = new[]{
    
    new {Nombre="alex",edad=19},
    new {Nombre = "maria", edad=20},
    new {Nombre= "pedro",edad=15}
}

para acceder:

    nombrearray[posicionElemento]


+++++++++++++++++++++++++++++++++++++++++++++++++++++++

BUCLE FOR:




 
 
 
 
 
 
 
 
 
 */