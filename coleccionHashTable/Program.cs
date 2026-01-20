using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coleccionHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

/*
 Colecciones: Hashtable

El hashtable es una colección indexada. Es decir que vamos a tener un indice y un valor referenciado a ese indice, sin embargo, la indexación no se lleva a cabo como en el arreglo o el ArrayList.

El lugar dentro del hashtable donde se coloca el elemento va a depender de un valor conocido como key o llave

el valor contenido en key es usado para calcular la posición del elemento en el hashtable. El elemento que vamos a colocar se conoce como value.

 siempre se va a tener una pareja key - value

Declaración:
        
    Si deseamos declarar e instanciar un hashtable llamado miTabla, es posible realizarlo prosiguiendo de la siguiente manera

    Hashtable miTabla = new Hashtable();
    
Adicion de elementos al Hashtable;

para insertar un elemento usamos el metodo Add();

este metodo a diferencia de los de las otras colecciones, va a necesitar de dos parametros. En el primer parámetro colocamos el key que será usado para indexar al elemento

este key puede ser de cualquier tipo, pero generalmente se utilizan cadenas.

el segundo parametro será el valor o elemento a insertar, tambien puede ser de cualquier tipo

ejemplo:
        
    miTable.Add("pan",5.77);
    miTable.Add("soda",10.85);
    miTable.Add("atun",15.50);
 
recorriendo el hashtable

para poder recorrer el hashtable, haremos uso del ciclo foreach. Si queremos obtener la pareja key-value, nos apoyamos en una clase conocida como DictionaryEntry. El diccionario tambien guarda parejas de datos

inicializa una instancia del tipo DictionaryEntry con la clave y el valor especificados

por ejemplo: si deseamos seguir con la impresión de los contenidos del hashtable, podemos hacer lo siguiente


foreach(DictionaryEntry datos in miTabla){

        Console.WriteLine("Key-{0}, Value -{1}", datos.Key, datos.Value);

}

obtener un elemento del HashTable

Siempre que se referencia al HashTable utilizando una key, sera retornado el valor correspondiente a dicha clave en un objeto de tipo Object por lo que es importante convertir el dato obtenido al tipo de dato adecuado.

    object valor = miTabla[2];--> se debe utilizar la palabra reservada Object ya que se recibe un dato con la nomenclatura clave-valor
 
 
 Borrar los contenidos del Hashtable:

usamos el metodo Clear(). Este metodo no necesita de ningun parámetro

ejemplo: 
            miTabla.Clear();

Encontrar si ya existe un key:

como no podemos repetir el mismo key para dos elementos, es necesario poder saber si ya existe determinado key en el Hashtable. Usamos el método Contains() o ContainsKey();

Este método necesita de un único parámetro que es el key a buscar y regresa un valor de tipo bool. Si el valor regresado es true significa que el key ya existe y si es false que no se encuentra en el Hashtable.

bool existe;--> se debe declarar una variable de tipo booleana

existe = miTabla.Contains("Pan");


Para encontrar si ya existe un value:

Igualmente podemos buscar adentro del Hashtable por un valor en particular. En este caso, usaremos el método ContainsValue();

como parámetro colocaremos el valor a buscar y el metodo regresara un booleano. Si el valor regresado es true, el value existe en el hashtable y el valor da false nos indica que no se encuentra.

bool existe;

existe = miTabla.ContainsValue(17.50);

Para eliminar o remover un elemento del HashTable:

Al eliminar elementos, removemos la pareja key-value del Hashtable.

Para poder llevar a cabo la eliminación, necesitamos conocer el key del valor a eliminar y utilizar el metodo Remove()

Este metodo necesita de un solo parametro que es el key del elemento a borrar


miTabla.Remove("Pan");











 
 */