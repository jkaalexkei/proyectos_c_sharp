using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioFunciones
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

            int unidades;
            int descuento;
            float calculo;
            float precio = 650f;
            float precioSinDescuento = 0f;
            float precioFinal;
            capturarDatos(out unidades);//recibimos la unidades ingresadas por el usuario
            calculo = calcularDescuento(unidades, precio, out descuento);//se recibe el valor del descuento
            if(calculo != 0)
            {
                precioSinDescuento = unidades * precio;
                precioFinal = precioSinDescuento - calculo;
                Console.WriteLine($"Precio sin descuento: {precioSinDescuento}  pesos");
                Console.WriteLine($"Descuento Otorgado: {descuento}% porciento");
                Console.WriteLine($"En funcion de las unidades ingresadas se le otorga un descuento de: {calculo} pesos");
                Console.WriteLine($"Precio a pagar: {precioFinal} pesos");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se logro el calculo del descuento");
                Console.ReadKey();
            }
            

        }

        static void capturarDatos(out int unidades)
        {
            Console.WriteLine("Ingrese el numero de unidades a comprar: ");
            unidades = Convert.ToInt32(Console.ReadLine());

        }

        static float calcularDescuento(int unidades, float precio, out int descuento)
        {
            float calculo = 0;

            if (unidades > 0 && unidades < 5)
            {
                descuento = 10;
                calculo = (((precio * Convert.ToSingle(unidades) * 10) / 100));//calculamos el valor del descuento
                return calculo;
            }
            else if (unidades >= 5 && unidades < 10)
            {
                descuento = 20;
                calculo = (((precio * Convert.ToSingle(unidades) * 20) / 100));
                return calculo;
            } else if (unidades >= 10)
            {
                descuento = 40;
                calculo = (((precio * Convert.ToSingle(unidades) * 40) / 100));
                return calculo;
            }
            else
            {
                descuento = 0;
                return 0.00f;
            }
            
            

         
        }





    }
}
