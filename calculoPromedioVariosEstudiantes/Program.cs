using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoPromedioVariosEstudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculo del promedio de notas de varios estudiantes

            int cantidadEstudiantes, cantidadMaterias;
            string[] nombresEstudiantes;
            string[] materiasEstudiantes;
            decimal suma, promedio;

            Console.WriteLine("Ingrese el numero de estudiantes a procesar");
            cantidadEstudiantes = Convert.ToInt32(Console.ReadLine());

            nombresEstudiantes = new string[cantidadEstudiantes];
            Console.WriteLine("Ingrese el nombre de los estudiantes");
           for (int e = 0; e < nombresEstudiantes.Length; e++)
            {
                nombresEstudiantes[e] = Console.ReadLine();
            }
            Console.WriteLine($"Se registraron {nombresEstudiantes.Length} estudiantes");
            for (int re = 0; re < nombresEstudiantes.Length;re++)
            {
                Console.WriteLine($"{nombresEstudiantes[re]}");
            }

            Console.WriteLine("Registro de asignaturas");
            Console.WriteLine("Ingrese la cantidad de materias a registrar");
            cantidadMaterias = Convert.ToInt32(Console.ReadLine());
            materiasEstudiantes = new string[cantidadMaterias];
            Console.WriteLine("Ingrese el nombre de las materias");
            for (int rn = 0; rn < materiasEstudiantes.Length;rn++ )
            {
                materiasEstudiantes[rn] = Console.ReadLine();
            }
            Console.WriteLine($"se registraron {materiasEstudiantes.Length} materias");

            Console.WriteLine("Cargar notas");

            int[,] notasEstudiantes = new int[nombresEstudiantes.Length,materiasEstudiantes.Length];

            for (int e = 0; e < nombresEstudiantes.Length;e++)
            {
                Console.WriteLine($"Cargar notas para el estudiantes {nombresEstudiantes[e]}");
                suma = 0;
                for (int n = 0; n < materiasEstudiantes.Length;n++)
                {
                    Console.Write($" {materiasEstudiantes[n]} ");
                    notasEstudiantes[e,n] = Convert.ToInt32(Console.ReadLine());
                    suma += notasEstudiantes[e, n];
                }

                promedio = (suma / notasEstudiantes.GetLength(1));
                Console.WriteLine($"El promedio para {nombresEstudiantes[e]} es {promedio}");
            }




        }
    }
}
