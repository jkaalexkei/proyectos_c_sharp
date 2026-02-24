using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerencia
{
    class Coche : Vehiculo
    {
        public void acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void frenar()
        {
            Console.WriteLine("frenando");
        }

        public override void conducir()//sobreescribimos el metodo conducir de la clase padre con override para adaptarlo a la clase hija
        {
            Console.WriteLine("Conduciendo el coche");
        }


    }
}
