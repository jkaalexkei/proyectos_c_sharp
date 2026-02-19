using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace documentacionPOO_dos
{
    internal class Prueba
    {
        public int num1,num2;
        string nombre;
        private static int contadorDeObjetos = 0;//declaracion de variable estatica
        public Prueba()
        {
            this.num1 = 0;
            this.num2 = 0;
            contadorDeObjetos++;//incrementamos variable en 1 por cada instancia
        }

        public Prueba(string name)
        {
            this.num1 = 10;
            this.num2 = 20;
            this.nombre = name;
            contadorDeObjetos++;

        }

        public static int ContadorObjetos()//metodo estatico
        {
            return contadorDeObjetos; 
        }

        //forma simplicada
        //public static int Contador() => contadorDeObjetos;

        public void llamada()
        {
            Console.WriteLine($"num1:{this.num1} , num2:{this.num2} , nombre: {this.nombre}");
        }

        public static void Metodo()
        {
            Console.WriteLine("hola");
        }
    }
}
