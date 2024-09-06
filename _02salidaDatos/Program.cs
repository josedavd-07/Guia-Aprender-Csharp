using System;

namespace _02salidaDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            // _02_salidaDatos

            // See https://aka.ms/new-console-template for more information

            Console.WriteLine("Hello, World!");
            Console.Write("Hello");
            Console.Write(" Mundo");

            /*
             * Estos ejemplos podemos ver como cada  metodo de salida de datos es diferente
             *
             * Tenemos los dos metodos  de la clase console que son:  Write y WriteLine
             *
             * Definicion del metodo Write: Este escribe toso en la misma linea no importa si la siguiente salida de Write esta abajo siempre va a quedar en la misma linea.
             *
             * Definicion del metodo Writeline: Este metodo escribe al igual que su hermano texto en una linea lo unico es que este da un salto de linea ya sea en escritura  o salida de datos.
             */

            //Ejemplos

            //Aca pondremos dos Console.WriteLine y a la hora de que ustedes lo ejecuten  miraran como uno da salto de linea del otro.

            Console.WriteLine("\nHola soy Writeline y quiero mostrarte como doy un salto de linea y no escribo junto como mi hermano Write");
            Console.WriteLine("Hola soy yo de nuevo  con un nuevo mensaje y para que mires como no me junto con el otro mensaje  porque siempre doy in salto de linea.");


            //Ahora veremos lo que es el Writemuesmi mama  
            //Como podran ver yo puedo escribir pegado y no como mi hermano que siempre da un salto y se separa

            Console.Write("Hola soy el hermano n°1 ");
            Console.Write("y yo el hermano N° 2 como ves nosotros dos  cuando hay dos lineas de write una debajo de la otra siempre estamso juntos y podemos ser usados para separar mensajkes pero poser ser mostrados en una sola linea");

            //Nota:
            /*
             * Hola soy yo de nuevo sabes hay veces que quieres dar otro salto de linea y no sabes como?
             * 
             * entonces estoy yo el \n  que permito que saltes de linea como lo podras ver te servira de mucho al organizar tu informacion. que se anima este con sin contrik"
             *
             * En C# es un lenguaje CaseSensitive lo que quiere decir que lo que es con mayuscula o minuscula debe ser escrito de tal forma porque si no no va a funcionar
             *
             ** Example**
             * Console, Write, WriteLine,Read, ReadLine. -Esta es la forma correctas de escribirlos  con su cada inicial mayuscula
             *
             * Estos  no se deben de escribir asi en minuscula.
             **Example**
             * console,write,writeline,read,readline.
             * si lo escribes asi tendras errores por que no va a correr.
             */

            //Ejemplo con \n

            Console.Write("doy un salto de line con mi amigo  \n");
            Console.Write("Viste cambie con un salto de linea  \n");

            Console.ReadKey();
        }
    }
}
