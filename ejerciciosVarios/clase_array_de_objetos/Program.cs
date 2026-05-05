using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_array_de_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlmacenarObjetos<string> obj = new AlmacenarObjetos<string>(5);//aqui se indica de manera estricta que el objeto AlmacenarObjetos solo guardara objetos de tipo string
            obj.AgregarObjetosAlmacen("string");
            obj.AgregarObjetosAlmacen("hola");
            obj.AgregarObjetosAlmacen("mundo");
            obj.AgregarObjetosAlmacen("generico");
            //obj.AgregarObjetosAlmacen(123);
            //obj.AgregarObjetosAlmacen(0.00);
            //obj.AgregarObjetosAlmacen(DateTime.Now);
            obj.AgregarObjetosAlmacen("");

            Console.WriteLine(obj.getObjeto(3));

        }
    }
}
