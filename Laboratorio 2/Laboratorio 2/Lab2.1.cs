using Microsoft.VisualBasic;
using System;

namespace Laboratorio21
{
    public class Program
    {
        public static void Main()
        {
            // Asignando valor a la variable estática.
            MyClass.valor = 1;
            Console.WriteLine(MyClass.valor);
        }
    }

    public class MyClass
    {
        // Declarando variables estáticas.
        public static int valor;
    }
}
