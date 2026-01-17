using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayBidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Permite organizar valores en filas y columnas

            conocidos como matrices

            para acceder usamos dos indices o posiciones (el de la fila y el de la cooluma)

            unidimensional

            {1,2,3,4,5,6}

            bidimensional

            |  1  2  3  | --> FILA
            |  4  5  6  |
            |  7  8  9  |
               | 
               L-> Columna

            sintaxis y declaracion

            declaracion de los arreglos de dos dimenciones

            float [,] tabla = new float[valor1,valor2]

            para esto se puede utilizar un ciclo for anidado

            int fila = 2;
            int colum = 2;
            int[,] array = new int[fila,colum];

            array[0,0] = 1
            array[0,1] = 2
            array[1,0] = 3
            array[1,1] = 4
            
            Para saber el tamaño, no nos basta con .length ya que esto solo nos da la cantidad total de datos del array
            se debe usar getLength(n) donde n=0 es el numero de la primera dimensión (tipicamente para saber las filas que contiene)
            se debe usar getLength(n) donde n=1 es el numero de la segunda dimensión (tipicamente para saber las columnas que contiene)

            ejemplo:
                        int[,] datos = new int[filas,columnas]
                        datos.getlength(0) -> hace referencia a la primera dimensión, es decir la longitud de las filas
                        datos.getlength(1) -> hace referencia a la segunda dimensión, es decir la longitud de las columnas
            
             */

            // columnas = salones un for para salones
            // filas = alumnos un for para alumnos
            //int f=2, c=5;
            //float[,] datos = new float[f, c];
            ////pedimos datos al usuario
            //for (int filas = 0; filas < 2;filas++)
            //{
            //    for (int colum = 0; colum < 5; colum++)
            //    {
            //        Console.WriteLine($"ingrese un datos: {filas+1},{colum+1} ");
            //        datos[filas,colum] = Convert.ToSingle(Console.ReadLine());
            //    }
            //}

            //Programa para el registro de notas:

            int estudiantes, notas;
            float promedio=0;//variable para cacular el promedio

            Console.WriteLine("Programa para registrar notas por estudiante");

            Console.WriteLine("Ingrese el numero de estudiantes a registrar");
            estudiantes = Convert.ToInt32(Console.ReadLine());//capturamos cantidad de estudiantes a registrar

            Console.WriteLine("Ingrese el numero de notas por estudiantes a registrar");
            notas = Convert.ToInt32(Console.ReadLine());//capturamos notas por estudiantes a registrar

            float[,] datos = new float[estudiantes, notas];//declaramos array bidimensional para registrar estudiantes y sus notas

            for (int filaEst = 0; filaEst < estudiantes;filaEst++)//recorremos los estudiantes para ingresar sus notas
            {
                Console.WriteLine("Ingresemos las notas para {0} estudiante", filaEst+1);
                for (int filasNotas = 0; filasNotas < notas;filasNotas++)//recorremos para ingresar la cantidad de notas por estudiantes
                {
                    Console.WriteLine("Ingrese la {0} nota",filasNotas+1);//ingresamos la nota
                    datos[filaEst, filasNotas] = Convert.ToSingle(Console.ReadLine());//asignamos la nota al array
                }
            }

            Console.WriteLine("Se registraron los siguientes Datos");//aqui mostramos los datos registrados
            for (int fe = 0; fe < estudiantes; fe++) //aqui recorremos los estudiantes
            {
                    Console.WriteLine($"Estudiante {fe+1}:");//indicamos el estudiante
                    for (int fn = 0; fn < notas;fn++)//recorremos las notas
                    {
                        Console.WriteLine($"<{datos[fe, fn]}>");//mostramos las notas
                    }
            }

            Console.WriteLine("El promedio de las notas es: ");//aqui calculamos el promedio de las notas registradas por estudiante
            for (int rowEst=0;rowEst < estudiantes;rowEst++)
            {
                float suma = 0;//iniciamos la variable suma en 0 para que por cada estudiante se haga la suma correcta y con esto reseteamos la variable en cada vuelta por estudiante
                for (int rowsNotas=0; rowsNotas<datos.GetLength(1);rowsNotas++)//recorremos las notas 
                {
                    suma += datos[rowEst, rowsNotas];//efectuamos la suma acumulando en cada vuelta la nota, sumandola y guardandola en la variable suma
                    
                }
                promedio = suma / datos.GetLength(1);//calculamos el promedio en funcion de la longitud de las columnas, esto se debe hacer por fuera del bucle que recorre las notas
                Console.WriteLine($"El promedio de las notas del estudiante {rowEst + 1} es {promedio}");//aqui mostramos el promedio en funcion del estudiante
            }
            

            Console.WriteLine("Fin del programa");
            Console.ReadKey();
        }
    }
}
