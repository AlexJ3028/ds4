using System;

namespace Numerosdel1a100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido querido usuario, le mostraré los números del 1 al 100.");
            Console.WriteLine("Si desea continuar en este programa, por favor presione la tecla 'H'.");

            // Variable para almacenar la tecla presionada
            ConsoleKeyInfo tecla;

            // Bucle que espera hasta que se presione la tecla 'H'
            do
            {
                // Capturar la tecla presionada por el usuario
                tecla = Console.ReadKey(true); // El parámetro 'true' evita que la tecla presionada se muestre en pantalla

            } while (tecla.Key != ConsoleKey.H); // Verificar si la tecla presionada es 'H'

            // Mensaje que confirma que la tecla correcta fue presionada
            Console.WriteLine("¡Gracias! Has presionado 'H'. Continuando con la ejecución del programa...");

            Console.WriteLine("Acepto seguir aquí, ahora le mostraré los números del 1 al 100:");

            // Mostrar los números del 1 al 100
            Console.WriteLine("Números del 1 al 100:");
            for (int i = 1; i <= 100; i++)
            {
                // Mostrar el número actual
                Console.Write("Número: " + i);

                // Verificar si el número es divisible entre 3
                if (i % 3 == 0)
                {
                    Console.Write(" - Divisible entre 3");
                }

                // Verificar si el número es par
                if (i % 2 == 0)
                {
                    Console.Write(" - Par");
                }

                // Nueva línea para mostrar el siguiente número
                Console.WriteLine();
            }

            Console.ReadLine(); // Mantener la consola abierta para ver los resultados
        }
    }
}

