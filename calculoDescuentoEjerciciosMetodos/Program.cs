using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoDescuentoEjerciciosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            un almacen de escritorios hace los siguientes descuentos: 

           si el cliente compra menos de 5 unidades se le da un descuento del 10% sobre la compra; 
           si el numero de unidades es mayor o igual a cinco pero menos de 10 se le otorga un 20% y, 
           si son 10 o mas se le da un 40%.

           Hacer un programa que determine cuando debe pagar un cliente si el valor de cada escritorio es de $650

           */

            int numeroEscritorios;
            decimal valorApagar;

            pedirDatos(out numeroEscritorios);//metodo que recibe numero de escritorios


            valorApagar = calcularValor(numeroEscritorios);
            mostrarResultados(valorApagar);

        }

        static void pedirDatos(out int numeroEscritorios)//la palabra out permite retornar un valor sin usar un return
        {

            Console.WriteLine("Ingrese numero de escritorios");
            numeroEscritorios = Convert.ToInt32(Console.ReadLine());   


        }

        static decimal calcularValor(int numeroEscritorios)
        {
            decimal valor = numeroEscritorios * 650;

            if (numeroEscritorios < 5)
            {
                return valor * 0.9m;
            }

            if (numeroEscritorios >= 5 && numeroEscritorios < 10)
            {
                return valor * 0.8m;
            }
            return valor * 0.6m;
        }

        static void mostrarResultados(decimal valorApagar)
        {
            Console.WriteLine("El valor a pagar es: {0:N0} pesos", valorApagar);
            Console.ReadKey();
        }
    }
}
