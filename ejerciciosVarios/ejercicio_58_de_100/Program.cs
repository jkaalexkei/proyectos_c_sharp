using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_58_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe una funcion que use parametros de salida
            // se usa la palabra reservada out en los parametros para dar salida a un valor
            int numero = 4;

            int resultado = 0;

            cuadrado(numero, out resultado);//lo que devuelve la funcion cuadrado se almacena en el parametro resultado

            Console.WriteLine(resultado);//imprimimos lo que tiene la variable resultado

            saludar(out string mensaje);//en la variable mensaje almacenamos lo que devuelve la funcion saludar

            Console.WriteLine(mensaje);//imprimimos ese valor

            string otroMensaje = "";
            otroMensajeNuevo(out otroMensaje);
            Console.WriteLine(otroMensaje);

            

        }

        public static void cuadrado(int numero, out int resultado)
        {
            resultado = numero * numero;
        }
        //lo que devuelva esta funcion va a salir a traves del parametro resultado

        static void saludar(out string mensaje)
        {
            mensaje = "Hola Mundo";
            
        }

        static void otroMensajeNuevo(out string otroMensaje)
        {
            otroMensaje = "comprendido";
        }
    }
}
