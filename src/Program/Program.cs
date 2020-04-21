
// Escribir una función que recibe una cadena de caracteres como parámetro con una fecha de la forma
// “dd/mm/aaaa” y devuelve la fecha en formato “aaaa­‐mm­‐dd”.
// Ej.: 10/11/1977 -> 1977­‐11­‐10
//
// La función para cambiar el forma de la fecha está implementada en el método de clase ChangeFormat de la
// clase Program. Ese método se invoca desde el método de clase Main de la clase Program que es el punto de
// entrada del programa.

//Se quita El Metodo de  ChangeFormat del Programa principal para ponerla en la carpeta Library 
//(Creando una clase Formato.cs), se crea la estructura de carpetas  
//con la que trabajaremos en el curso.
// La idea es Utiizar el Principio SRP para que el Formateo sea responsabilidad de Formato.cs y no de Program.cs
//y minimizar la razon de cambio de esta Clase.
using System;
using Library;

namespace DateFormat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, Formato.ChangeFormat(testDate));
        }
    }
}