using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioTresArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Ejercicio 3: Búsqueda de número en array (unidemensional)

                Crea un programa al usuario que ingrese un número y luego buscarás si ese número existe en un array dado.

                Define el tamaño del array como desees y los valores que desees:


                Reglas:

                Utiliza una variable de tipo bool - encontrado

                Utiliza el ciclo foreach y la estructura if para hacer el recorrido del array

                Utiliza una segunda estructura if para las impresiones por pantalla de los resultados de la búsqueda
             
             */

            int cantidad,buscar;
            bool encontrado;
            int[] numeros;

            Console.WriteLine("Ingrese la cantidad de numeros a procesar");
            cantidad = Convert.ToInt32(Console.ReadLine());

            numeros = new int[cantidad];

            Console.WriteLine("Registre los valores");
            for (int i = 0; i < numeros.Length;i++)
            {
                Console.Write($"Valor {i+1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("valores registrados: ");
            encontrado = false;
            foreach (int item in numeros)
            {
                Console.WriteLine(item);
            }
            //OPCION 1 PARA BUSCAR UN ELEMENTO
            /*
            Console.WriteLine("Ingrese el numero a buscar");
            buscar = Convert.ToInt32(Console.ReadLine());

            encontrado = false;//ESTA VARIABLE SE USARIA PARA VALIDAR SI EL REGISTRO EXISTE

            foreach (int item in numeros)//RECORREMOS LOS ELEMENTOS DEL ARREGLO
            {
                if (item == buscar)//COMPROBAMOS SI EL ITEM DEL ARRAY ES IGUAL A LO QUE INGRESO EL USUARIO
                {
                    encontrado = true;//SI LO ENCUENTRA EL VALOR DE LA VARIABLE SE CAMBIA A TRUE
                    break;//SE SALE DEL CICLO
                }
               
            }

            if (encontrado)//SI LA VARIALE ENCONTRADO ES VERDADERA QUIERE DECIR QUE EL REGISTRO EXISTE
            {
                Console.WriteLine("Registro existe");
            }
            else
            {
                Console.WriteLine("Registro no existe");
            }*/

            //OPCION 2 USANDO LA CLASE ARRAYS Y EL METODO INDEXOF

            Console.WriteLine("Ingrese el numero a buscar");
            buscar = Convert.ToInt32(Console.ReadLine()) ;

            //int posicion = Array.IndexOf(numeros, buscar); //esto devuelve la posición del elemento buscado en el array

            //if (posicion > 0)//si la variable posicion es mayor a cero significa que el elemento existe
            //{
            //    Console.WriteLine($"El numero {buscar} se encuentra en la posición {posicion} del array");
            //}
            //else
            //{
            //    Console.WriteLine("El número buscado no existe");
            //}

            //Console.WriteLine("Fin del programa");

            //OPCION 3 SI EL ELEMENTO APARECE EN VARIAS POSICIONES:
            int[] apariciones = new int[numeros.Length];//creamos un nuevo array para almacenar la cantidad de veces que aparece un numero
            int contador = 0;

            for (int k = 0; k < numeros.Length;k++)
            {
                if (numeros[k] == buscar)//validamos si el elemento es igual a lo que contiene la variable buscar
                {
                    apariciones[contador] = k;//aqui se guarda la posicion del elemento encontrado utilizado el valor de la variable contador como indice de la posicion
                    contador++;//aqui por cada aparición aumentamos el contador
                }
            }

            if (contador > 0)//aqui contador debe ser igual al numero de apariciones encontradas
            {
                Console.WriteLine("El numero buscado aparece en: ");
                for (int a = 0; a < contador;a++)//aqui recorremos el array con el numero de apariciones encontradas
                {
                    Console.WriteLine($"Posición {apariciones[a]}");//aqui mostramos la posicion en las que aparece el numero
                }
            }
            else
            {
                Console.WriteLine("El numero no existe");
            }






















        }
    }
}
