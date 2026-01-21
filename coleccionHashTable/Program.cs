using System;
using System.Collections;
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

            int opcion = 0;
            decimal numero = 0;
            string key = "";
            bool encontrado = false;

            Hashtable miTabla = new Hashtable();//inicializamos el Hashtable

            //se usa el bucle do while cuando al menos el programa se deba ejecutar una vez
            do
            {
                //menu de opciones
                Console.WriteLine("1. Add -> Adicion de elementos");
                Console.WriteLine("2. Object -> obtener un elemento");
                Console.WriteLine("3. Clear  -> Borrar hashtable");
                Console.WriteLine("4. Contains o ContainsKey -> buscar segun una key");
                Console.WriteLine("5. ContainsValue -> buscar por value");
                Console.WriteLine("6. Remove -> borrar usando un key");
                Console.WriteLine("7. listar -> listar elementos");
                Console.WriteLine("8. Salir");
                Console.WriteLine("Escoge una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------");
                //verificar opcion ingresada por el usuario
                if (opcion == 1)//si usuario ingreso 1
                {
                    Console.WriteLine("Ingrese un precio producto: ");//agregar valor al Hashtable
                    numero = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Ingrese un nombre producto: ");//agregar valor al Hashtable
                    key = Console.ReadLine();
                    Console.WriteLine("-------");
                    //adicionamos valor al Hashtable
                    miTabla.Add(key,numero);//agrega al Hashtable el valor ingresado por el usuario (clave, valor)
                    Console.WriteLine($"se agrego el elemento: key={key} - value={numero}");
                }
                else if (opcion == 2)
                {
                    //obtener elemento mediante la llave del hashtable y se convierte a objeto para poderlo mostrar
                    Object llave = miTabla[key];

                    //mostrar elemento obtenido
                    Console.WriteLine($"el valor obtenido es: {llave}");

                }
                else if (opcion == 3)
                {
                    //limpiar todos los elementos del Hashtable
                    miTabla.Clear();

                }
                else if (opcion == 4)
                {
                    //pedimos el valor a mostrar - consultar elemento
                    Console.WriteLine("Ingrese el nombre a consultar:");
                    key = Console.ReadLine();
                    Console.WriteLine("-------");


                    //validamos si el numero se encuentra en el Hashtable
                    encontrado = miTabla.ContainsKey(key);//esto retorna verdadero o falso si el elemento aparece en el hashtable
                    Console.WriteLine("Encontrado {0}", encontrado);

                }
                else if (opcion == 5)
                {

                    //pedimos el valor a mostrar - consultar elemento
                    Console.WriteLine("Ingrese el precio a consultar:");
                    numero = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("-------");


                    //validamos si el numero se encuentra en el Hashtable
                    encontrado = miTabla.ContainsValue(numero);//esto retorna verdadero o falso si el elemento aparece en el hashtable
                    Console.WriteLine("el precio encontrado {0}", encontrado);
                }
                else if (opcion == 6)
                {

                    //remover hashtable
                    miTabla.Remove(key);
                    Console.WriteLine("Elemento Borrado {0}", key);
                }
                else if (opcion == 7)
                {

                    //listar hashtable
                    foreach (DictionaryEntry tabla in miTabla)//recorremos los elementos de la pila
                    {
                        Console.WriteLine($"key={tabla.Key} - Value={tabla.Value}");//para leer los valores se debe hacer a traves de la clave y valor
                    }
                    Console.WriteLine("-------");
                }
                else if (opcion == 8)
                {

                    Console.WriteLine("Fin del Programa");
                    break;
                }
                else
                {
                    Console.WriteLine("Opcion no contemplada en el Menú");
                }

                //mostrar información del Hashtable
                Console.WriteLine($"El Hashtable tiene {miTabla.Count} elemento");
                

            } while (opcion != 8);


            Console.ReadKey();



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