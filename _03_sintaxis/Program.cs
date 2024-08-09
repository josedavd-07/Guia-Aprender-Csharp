// _03_sintaxis


Using System;

namespace sintasix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");    
            Console.ReadKey();
        }
    }
}

//El ejemplo esta hecho sin instrucciones de nivel superior esta atento en ocasiones veras que habran cosas que podre hacerlas con instrucciones de nivel superior.
/*
Ejemplo explicado
Línea 1: significa que podemos usar clases del espacio de nombres : Using System

Línea 2: Una línea en blanco. C# omite los espacios en blanco. Sin embargo, varias líneas hacen que el código sea más legible.

Línea 3: se utiliza para organizar el código y es un contenedor para clases y otros espacios de nombres.namespace

Línea 4: Las llaves marcan el principio y el final de un bloque de código.{}

Línea 5: es un contenedor de datos y métodos, que aporta funcionalidad a su programa. Cada línea de código que se ejecuta en C# debe estar dentro de una clase. En nuestro ejemplo, nombramos a la clase Program.class

No te preocupes si no entiendes cómo funciona y cómo funciona. Piensa en ello como algo que (casi) siempre aparece en tu programa, y que aprenderás más sobre ellos en un capítulo posterior.using Systemnamespaceclass

Línea 7: Otra cosa que siempre aparece en un programa de C# es el método. Cualquier código dentro de sus llaves será ejecutado. No tienes que entender las palabras clave antes y después de Main. Llegarás a Conócelos poco a poco mientras lees este tutorial.Main{}

Línea 9: es una clase del espacio de nombres, que tiene un método que se utiliza para imprimir/generar texto. En nuestro ejemplo, dará como resultado "¡Hola mundo!". ConsoleSystemWriteLine()

Si omite la línea, tendrá que escribir para imprimir/generar texto.using SystemSystem.Console.WriteLine()

Nota: Cada instrucción de C# termina con un punto y coma .;

Nota: C# distingue entre mayúsculas y minúsculas; "Mi Clase" y "Mi Clase" have significado diferente.

Nota: A diferencia de Java, el nombre del archivo C# no tiene por qué coincidir con el nombre de la clase, pero a menudo lo hacen (para una mejor organización). Al guardar el archivo, guárdelo con un nombre propio y agregue ".cs" al final de el nombre del archivo.
*/
