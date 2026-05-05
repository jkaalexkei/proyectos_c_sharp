using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace clase_array_de_objetos
{
    class AlmacenarObjetos<T>//declaracion de una clase generica
    {
        private T[] Almacen;//se reemplaza la clase Object por T que indica objeto generico
        //public Object[] pAlmacen
        //{
        //    get { return Almacen; }

        //    set
        //    {
        //        try
        //        {
        //            if (value == null)
        //            {
        //                throw new ArgumentNullException("value");
        //            }
        //            Almacen = value;
        //        }
        //        catch (ArgumentNullException ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //}


        private int CantidadObjetos { get; set; }
        private int contador;

        public AlmacenarObjetos(int cantidad)
        {
            this.Almacen = new T[cantidad];//Aqui se instancia y se indica que cantidad de elementos tendra el objeto generico
            contador = 0;
        }

        public T getObjeto(int posicion)//el tipo de dato que retornara la funcion para obtener el objeto del array es de tipo generico
        {
            return this.Almacen[posicion];
        }

        public void AgregarObjetosAlmacen(T objeto)
        {
            this.Almacen[contador] = objeto;
            contador++;
        }


    }
}
