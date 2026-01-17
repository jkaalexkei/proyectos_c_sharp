using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglosJagged_arreglos_en_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ARREGLOS (JAGGED) arreglos en arreglos
             
                cada elemento del arreglo es un arreglo en si
                nos ayuda a ahorrar memoria
                mas flexibles pero requieren mas atención
            
            
            Declaración:

            1.- se declara primero el arreglo contenedor

                    int [][] costos = new int[3][]; -> esto indica que tiene 3 columnas, los siguientes corchetes se dejan vacios para tener flexibilidad de darle un tamaño propio a cada fila


            2.- se declaran los arreglos
                        
                            aqui se especifica las columnas = aqui se especifican las filas que va a tener cada columna
                            columna 0 = tendra 15 filas
                            costos[0] = new int[15];
                            costos[1] = new int[20];
                            costos[2] = new int[10];

            formas de declarar:
                
            int[][] valores = new int[3][];
                
                    valores[0] = new int[]{1,2,3,4,5,6,7} en la 1ra columna 7 filas
                    valores[1] = new int[]{1,2,3} en la 2da columna 3 filas
                    valores[2] = new int[]{1,2,3,4,5} en la 3ra columna 5 filas


             int[][] valores = new int[][]
                                            {
                                                new int[]{1,2,3,4,5}
                                                new int[]{1,2}
  }                                             new int[]{1,2,3,4,5,7,8,9}
                                            };

            Acceder a elementos de un arreglo jagged

            Para acceder a los elementos guardados adentro de un arreglo jagged tambien necesitamos utilizar indices, un indice sera aplicado para indicar cual elemento del arreglo contenedor utilizaremos, es decir, el numero de columna. El otro indice nos indicara el elemento del arreglo interno que queremos acceder:

            arreglo[columna][filas]

            por lo general en las columnas va el dato ingresado por el usuario y las filas son las que varian

            productos[6][7] = 5,7f;

           

             */

            int columnas = 0;
            int filas,cantidad;

            Console.WriteLine("Ingrese la cantidad de columnas");
            columnas = Convert.ToInt32(Console.ReadLine());

            int[][] arregloJagged = new int[columnas][];

            for (int i = 0; i < columnas;i++)
            {
                Console.WriteLine("Ingrese el valor para la columna {0}", i);
                cantidad = Convert.ToInt32(Console.ReadLine());
                //instanciamos el arreglo para inicializarlo
                arregloJagged[i] = new int[cantidad];

            }
            //recorremos los valores del arreglo
            for (int j = 0; j<columnas;j++)
            {
                //recorremos los valores por cada columna
                Console.WriteLine("columna {0}",j);
                //recorremos los valores por cada fila para agregar registros
                for (int m = 0; m < arregloJagged[j].GetLength(0);m++)//se obtiene la dimensión del arreglo (cantidad de filas)
                {
                    Console.WriteLine("ingrese el valor para las filas: ");
                    arregloJagged [j][m] = Convert.ToInt32(Console.ReadLine());//agregamos los valores al array (en la columna j agregamos los valores a las filas m

                }
            }

            Console.WriteLine("Información cargada");
            for (int p = 0; p < columnas; p++) 
            {
                Console.WriteLine("Valores para la columna {0}", p);
                for (int l = 0; l < arregloJagged[p].GetLength(0);l++)
                {
                    Console.WriteLine($"{arregloJagged[p][l]}");
                }
            }

            Console.WriteLine("Fin del programa");

            Console.ReadKey();
        }
    }
}
