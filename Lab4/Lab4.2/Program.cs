using System;

namespace Lab42 
{
    class Program
    {
        // Inicializa el programa
        static void Main(string[] args)
        {
            // Muestra un mensaje al iniciar el programa
            Console.WriteLine("Programa iniciado.");

            int fac = 1, n;
            string linea;

            // Solicita al usuario que ingrese un valor para n
            Console.Write("Ingrese un número entero: ");
            linea = Console.ReadLine();

            // Convierte la entrada del usuario en un número entero
            n = int.Parse(linea);

            // Bucle para calcular el factorial
            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }

            // Muestra este mensaje para dar el resultado de la operación previa
            Console.WriteLine("El factorial es: " + fac);
            Console.ReadKey();

            // Evita que la consola se cierre inmediatamente y finaliza el programa
            Console.WriteLine("\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}



