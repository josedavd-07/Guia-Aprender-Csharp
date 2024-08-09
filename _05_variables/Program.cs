/**
    * Como declarar variables en C# y sus tipos de datos.
    * Las variables son recipientes para almacenar los valores de datos.
    * En C#, hay diferentes tipos de variables (definidas con diferentes palabras clave), por ejemplo:

    * int- tiendas enteros (números enteros), sin decimales, tales como 123 o -123.
    * double- almacena números de punto flotante, con decimales, como 19.99 o -19.99.
    * char- almacena personajes individuales, como 'a' o 'B'. Los valores de los cartos están .............rodeados de citas individuales
    * string- almacene en texto, como "Hola Mundo". Los valores de la cuerda están rodeados de comillas dobles
    * bool- almacena valores con dos estados: true o falso.

*/


//Declarando una variable

// Sintaxis de una variable en C#:
// Para crear una variable, debe especificar el tipo y asignarle un valor:
// type variableName = value;


//Donde el tipo es de tipo daro en C# es  (como into o string), y variableNombre es el nombre de la variable (como x o nombre). El mismo signo se utiliza para asignar valores a la variable.

//Para crear una variable que debe almacenar texto, miremos el siguiente ejemplo:

// Crear una variable llamada nombre de tipo stringy asignarle el valor " John ":

string name = "John";
Console.WriteLine(name);

//para crear una variable que debe almacenar un número, mire el siguiente ejemplo:

// Crear una variable llamada myNum de tipo int y asignarle el valor 15:

int myNum = 15;
Console.WriteLine(myNum);

// También se  puede declarar una variable sin asignar el valor, y asignar el valor posterior:

int myNums;
myNums = 15;
Console.WriteLine(myNums);

// Tenga en cuenta que si asigna un nuevo valor a una variable existente, sobrescribirá el valor anterior:

// Cambiar el valor de myNuma 20:
int myNum = 15;
myNum = 20; // myNum is now 20
Console.WriteLine(myNum);

// Otros tipos

// Una demostración de cómo declarar variables de otros tipos:


// Ejemplo

int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";





