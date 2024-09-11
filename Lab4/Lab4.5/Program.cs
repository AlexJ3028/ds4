using System;

namespace Lab45
{
    class Program
    {
        // Inicializa el programa
        static void Main(string[] args)
        {
            // Muestra un mensaje al iniciar el programa
            Console.WriteLine("Programa iniciado.");

            // Declaración de variables
            int edad1, edad2, edad3, edad4, edad5;

            // Inicialización de variables
            edad1 = edad2 = edad3 = edad4 = 32;
            edad5 = 31;

            // Muestra los valores de las edades
            Console.WriteLine("Edades: {0}, {1}, {2}, {3}, {4}", edad1, edad2, edad3, edad4, edad5);

            // Evita que la consola se cierre inmediatamente
            Console.WriteLine("\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}


