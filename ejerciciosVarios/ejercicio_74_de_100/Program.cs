using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_74_de_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribe un programa que lance una excepción manualmente para validar la edad
            Persona persona = new Persona();
            persona.edad(-18);
            persona.edad(18);
        }
    }

    class Persona
    {
        public void edad(int ed)
        {
            try
            {
                if(ed < 0 || ed > 120)
                {
                    throw new Exception("edad invalida");
                }
                Console.WriteLine("edad correcta");
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("excepcion: {0}",ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }
        }
    }
}
