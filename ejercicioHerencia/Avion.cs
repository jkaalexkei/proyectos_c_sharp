using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioHerencia
{
    class Avion : Vehiculo
    {
        public void aterrizar()
        {
            Console.WriteLine("Aterrizando");
        }

        public void despegar()
        {
            Console.WriteLine("Despegando");
        }
        public override void conducir()
        {
            Console.WriteLine("volando el avion");
        }
    }
}
