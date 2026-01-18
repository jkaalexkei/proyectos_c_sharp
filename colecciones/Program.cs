using System;
using System.Collections;//se usa para trabajar con colecciones
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice, cantidad;

            ArrayList datos = new ArrayList();

            datos.Add(7);//agregamos elementos al ArrayList
            datos.Add(5);
            datos.Add(1);
            

            Console.WriteLine("estos son los datos: ");
            Console.WriteLine("---------------------");
            imprime(datos);//Llamamos a la funcion que recorre los elementos del ArrayList y recibe como parametro un ArrayList
            Console.WriteLine("---------------------");
            datos.Add(9);
            indice = datos.Add(10);//esto retorna el indice del elemento agregado
            Console.WriteLine("Despues de aumentar el array");
            imprime(datos);
            Console.WriteLine("---------------------");
            Console.WriteLine($"el indice del ultimo elemento agregado es: {indice}");//aqui mostramos la posicion del ultimo elemento agregado
            Console.WriteLine("---------------------");
            Console.WriteLine($"El valor del elemento 2 del arrayList es: {datos[2]}");//aqui mostramos un elemento especifico
            Console.WriteLine("---------------------");
            //para modificar un elemento se puede hacer de la siguiente forma

            datos[2] = 20;
            Console.WriteLine("ArrayList con la modificación en el elemento 2");
            imprime(datos);
            Console.WriteLine("---------------------");
            //obtener la cantidad de elementos del arrayList
            cantidad = datos.Count;//retorna la cantidad de elementos del arrayList
            Console.WriteLine($"El arrayList tiene {cantidad} elementos");
            Console.WriteLine("---------------------");
            //insertar un elemento
            datos.Insert(2,40);//en la posicion 2, se inserta el numero 40
            Console.WriteLine("ArrayList con la inserción del dato nuevo");
            imprime(datos);
            cantidad = datos.Count;
            Console.WriteLine($"El arrayList tiene {cantidad} elementos");
            Console.WriteLine("---------------------");
            //remover un elemento
            datos.RemoveAt(2);
            Console.WriteLine("ArrayList con la remoción del el elemento 2");
            imprime(datos);
            cantidad = datos.Count;
            Console.WriteLine($"El arrayList tiene {cantidad} elementos");
            Console.WriteLine("---------------------");
            //buscar un elemento por su posición o indice

            indice = datos.IndexOf(5);//retorna la posición en la posición el numero 5
            Console.WriteLine($"La posición del 5 es {indice}");
            Console.WriteLine("---------------------");
            Console.ReadKey();

        }

        static void imprime(ArrayList datos)//Función para recorrer los elementos del ArrayList
        {
            foreach (int item in datos)//Recorremos los elementos
            {

                Console.WriteLine(item);//mostramos los elementos en pantalla
                Console.WriteLine("*******");
            }
            //Console.ReadKey();
        }
    }
}

/*
 
 Colecciones:

    Son estructuras de datos que nos permiten guardar en su interior cualquier tipo de información. Existen diferentes tipos de colecciones y la forma como se guarda, se accede y se elimina la información en cada una de ellas es distinta.

> son similares a variables y arreglos
> no es necesario indicar la cantidad de elementos, esto se puede hacer de manera dinamica
> tipos de colecciones:
    .- ArrayList
    .- Hashtable
    .- Queue
    .- Stack

 > se pueden recorrer con foreach

 > ArrayList: guarda la información como si fuera una lista. Y sobre esta lista es posible realizar diferentes actividades con los elementos almacenados.

   Un ArrayList: Arreglo que puede cambiar su tamaño según lo necesitamos.
    + puede cambiar el tamaño de manera dinamica durante la ejecución del programa
    + es una clase de c# por lo que va a tener metodos para poder trabajar con los datos
    + propiedades: 
        -capacidad: indica el tamaño que ocupa la lista
        -conteo: indica cuántos elementos está guardando en su interior.
> debemos usar el namespace System.Collections el cual nos va a permitir trabajar con colecciones

declaracion:

        ArrayList datos = new ArrayList();

si conocemos la cantidad de elementos:

        ArrayList datos = new ArrayList(32);

> para adicionar información al ArrayList se debe usar el metodo Add(). Esta información se agrega al final del ultimo elemento

>El metodo Add() va a necesitar de un único parámetro y este es el dato que queremos guardar. Enteros, variables, cadenas, otros. Ejemplo:

    
    datos.Add(7); dato de tipo entero
    datos.Add(n); guardamos la info de una variable
    datos.Add("Hola"); guardamos una cadena

> para acceder a la información de un ArrayList se debe hacer de la siguiente manera:
    - se puede acceder a traves de su indice

    Console.WriteLine("El dato es : {0}",datos[2]);
    impuestos = datos[2] * 0.15f;
    datos[2] = 5;

    - para obtener la cantidad de elementos en un ArrayList: Usando la propiedad count

        elementos = datos.Count;

> para insertar elementos: se debe usar el metodo Insert(posicion o indice en la que se va a insertar, valor a insertar)
> con este metodo se puede indicar la posición donde se quiere insertar el elemento

> por ejemplo, si deseamos insertar el valor de 5 en el indice 2, hacemos lo siguiente:

                    datos.Insert(2,5);

> el ArrayList crecerá su tamaño según sea necesario.
> para remover un elementos: se debe conocer el indice del elemento a eliminar
> el metodo que se encarga de llevar a cabo la eliminación es RemoveAt()
>ejemplo: 
            datos.RemoveAt(7); --> esto eliminara el elemento que se encuentre en la posicion 7 del ArrayList

> para encontrar un elemento se usa el metodo IndexOf().
> este metodo regresa un valor entero y si el elemento no se encuentra en el ArrayList, entonces devuelve el valor de -1

> si deseamos es buscar el indice donde se encuentra el elemento 7 se haria de la siguiente manera

    indice = datos.IndexOf(7); Esto devolveria el valor del elemento que esta en la posición 7

 */