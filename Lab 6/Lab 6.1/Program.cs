using System;

namespace Lab61
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicialización del programa
            Console.WriteLine("Digite el número deseado:");

            int num; // Declaración de la variable 'num'

            try
            {
                // Conversión de entrada a número entero
                num = int.Parse(Console.ReadLine()); // Uso correcto de int.Parse
            }
            catch (FormatException ex)
            {
                // Captura la excepción si no se introduce un número válido
                Console.WriteLine("No ha introducido un dígito válido.");
                num = -1; // Asigna un valor de error si hay una excepción
            }

            // Imprime el número o el valor -1 en caso de error
            Console.WriteLine(num);
        }
    }
}

