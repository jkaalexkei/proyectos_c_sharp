using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_75_de_100
{
    class Eiex : Exception//declaracion de una excepcion personalizada
    {
        public Eiex(string mensaje) : base(mensaje) //aqui le pasamos el mensaje a la clase exception mediante la instruccion base
        { }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //crear una excepcion personalizada y usala en un programa

            //eix = EdadInvalidaExcepcion

            ValidarEdad();
           


        }

        static public void ValidarEdad()
        {
            try
            {
                int edad = 4;
                if (edad < 0 || edad > 120)
                {

                    throw new Eiex("Edad Invalida");
                }
                Console.WriteLine("Edad correcta");

            }
            catch (Eiex ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

//Eiex exc = new Eiex("Hola");
//exc.ValidarEdad(-8);
//           
//        {
//            try
//            {

//            }
//            catch (Eiex ex)
//            {

//               
//            }
//        }
//    }
//    }
//}





