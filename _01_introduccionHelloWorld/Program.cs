// _01_introduccionHelloWorld
/**
    * Con uso de instrucciones superior es un codigo mas limpio y corto
    * es usado para proyectos cortos y pequeños para basarse solo en la logica
 */

// Este es un codigo usando instrucciones de nivel superior.

// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

// Este es un codigo en el cual no usamos instrucciones de nivel superior en el codigo  esta era la manera tradicciona de hacerlo como siempre.

/**
    * asi se veria si no usamos instrucciones de nivel superior
    * esta es la forma que se usa en proyectos mas grandes
    * por mayor orden de codigo utilizamos todas las estructuras
 */






//Nos permite usar la clase console que se encuentra en System , y a su vez los metodos de la clase Console
using System;

//Nombre del proyecto o espacio de nombres
namespace _01_introduccionHelloWorld  
{
    //Clase principal del proyecto
    internal class Program
    {
        //Esto hace referencia a un metodo vacio que asu ves contiene el punto de ejecucion Main
        //Y que contien el array de caracteres de tipo string con sus argumentos 
        static void Main(string[] args)
        {
            //Metodo WriteLine  de la clase Console que nos permite imprimir un valor en consola con salto de linea 
            Console.WriteLine("Hello, World!");

            //Metodo que espera la ejecución de la consola para poder cerrarse, sin ella se ejecutaba el programa y se cerraria automaticamnete
            Console.ReadKey();
        }
    }
}
