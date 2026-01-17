using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayBidimensionalCalculoNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Registrar Estudiantes
            int cantidadEstudiantes,cantidadMaterias,notas,estudiantes; 
            float notaMayor, notaMenor; float suma, promedio; 
            //cpaturamos cantidad de estudiantes y materias a registrar
            Console.WriteLine("Programa para registrar calificaciones");
            Console.WriteLine(""); Console.Write("Ingrese la cantidad de estudiantes a registrar: ");
            cantidadEstudiantes = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Ingrese la cantidad de materias a registrar para los estudiantes: ");
            cantidadMaterias = Convert.ToInt32(Console.ReadLine()); 
            //****************************************************************************************************** 
            //registramos los estudiantes
            string[] listaEstudiantes = new string[cantidadEstudiantes]; 
            for (int e=0; e < listaEstudiantes.Length;e++) 
            { Console.WriteLine("Ingrese el nombre del {0} estudiante: ", e + 1); 
                listaEstudiantes[e] = Console.ReadLine();
            } 
            //***************************************************************************************** 
            //registramos las materias
            string[] listaMaterias = new string[cantidadMaterias]; 
            for (int m = 0; m < listaMaterias.Length; m++) 
            { 
                Console.WriteLine("Ingrese el nombre de la {0} materia: ", m + 1); 
                listaMaterias[m] = Console.ReadLine();
            }
            //*********************************************************************************************** 
            //mostramos nombres de estudiantes registrados
            Console.WriteLine("Se han registrado los siguientes estudiantes: ");
            for (int i = 0;i<listaEstudiantes.Length;i++)
            { 
                Console.WriteLine(listaEstudiantes[i]);
            
            } 
            //**************************************************************************************** 
            //mostramos nombres de materias registrados
            Console.WriteLine("Se han registrado las siguientes materias: ");
            for (int j = 0;j<listaMaterias.Length;j++)
            { 
                Console.WriteLine(listaMaterias[j]);
            } 
            //**************************************************************************************
            //PROCESO PARA REGISTRAR LAS NOTAS POR ESTUDIANTE

            Console.WriteLine("Registro de calificaciones"); 
            estudiantes = listaEstudiantes.Length;
            Console.WriteLine("Estudiantes Registrados: {0}", estudiantes); 
            notas = listaMaterias.Length; 
            Console.WriteLine("Materias registradas {0}",notas); 
            float[,] datosEstudiantes = new float[estudiantes, notas];
            //recorremos la fila de estudiantes
            for (int filaE=0;filaE<estudiantes;filaE++)
            { 
                Console.WriteLine($"Ingrese las notas para el estudiante {listaEstudiantes[filaE]}");
                //registramos las notas
                float suma2 = 0;
               
                for (int filaN = 0; filaN < notas; filaN++)
                { 
                    Console.Write($"Ingresa la nota {filaN + 1} para la materia {listaMaterias[filaN]}: "); 
                    datosEstudiantes[filaE, filaN] = Convert.ToSingle(Console.ReadLine());
                    suma2 += datosEstudiantes[filaE, filaN];
                    Console.WriteLine($"{listaMaterias[filaE]} = {datosEstudiantes[filaE, filaN]}");
                }
               
                promedio = suma2 / datosEstudiantes.GetLength(1);
                Console.WriteLine($"promedio de calificaciones: {promedio}");
            } 
            //calculamos el promedio de notas por estudiantes
            Console.WriteLine("Los promedio de notas por estudiante son: ");
            //recorremos los estudiantes registrados
            //for (int estReg = 0; estReg < listaEstudiantes.Length;estReg++)
            //{ 
            //    Console.WriteLine($"El estudiante {listaEstudiantes[estReg]} obtuvo el siguiente promedio: "); 
            //    Console.WriteLine("Notas promediadas"); 
            //    //recorremos las notas para calcular el promedio
            //    suma = 0;
            //    for (int notasReg = 0; notasReg < datosEstudiantes.GetLength(1);notasReg++) 
            //    {
            //        suma += datosEstudiantes[estReg, notasReg]; 
            //        Console.WriteLine($"{listaMaterias[notasReg]} = {datosEstudiantes[estReg, notasReg]}"); 
            //    } 
            //    promedio = suma / datosEstudiantes.GetLength(1);
            //    Console.WriteLine($"promedio de calificaciones: {promedio}");
            //} 
            //validamos la nota mas alta por estudiante
            Console.WriteLine("Nota mas alta por estudiante"); 
            Console.WriteLine("");
            //recorremos los estudiantes 
            //Console.WriteLine("{0},{1}",notaMayor,notaMenor);
            for (int fe = 0; fe < datosEstudiantes.GetLength(0); fe++)
            { 
                //recorremos las notas
                notaMayor = datosEstudiantes[fe, 0]; //iniciamos la variable con la primera nota de un estudiante especifico de la matriz
                int indiceNotaMayor=0;//Variable para capturar el indice de la materia con nota mas alta 
                notaMenor = datosEstudiantes[0, 0]; 
                for (int fn = 0; fn < datosEstudiantes.GetLength(1); fn++)
                { 
                    if (datosEstudiantes[fe,fn] > notaMayor)//validamos la nota mas alta
                    {
                        notaMayor = datosEstudiantes[fe, fn];//asignamos la nota mas alta
                        indiceNotaMayor = fn;//asignamos el indice de la nota mas alta
                    } 
                } 
                Console.WriteLine($"La nota mayor para {listaEstudiantes[fe]} es la materia {listaMaterias[indiceNotaMayor]} con un puntaje de {notaMayor}");
                Console.WriteLine(""); 
            } 
            Console.WriteLine("Fin del programa"); 
            Console.ReadKey();
        }
    }
}
