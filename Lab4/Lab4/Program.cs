using System;

namespace Lab41
{
    class Program
    {
       
        // Inicializa el programa
        static void Main(string[] args)
        {
            // Muestra un mensaje al iniciar el programa
            Console.WriteLine("Programa iniciado.");

            int n, x;
            string linea;

            // Solicita al usuario que ingrese un valor para n
            Console.Write("Ingrese un valor n: ");
            linea = Console.ReadLine();

            // Convierte la entrada del usuario en un número entero
            n = int.Parse(linea);

            x = 1;

            // Bucle para mostrar los valores del 1 hasta n
            while (x <= n)
            {
                Console.Write(x);
                Console.Write(" , ");
                x = x + 1; // Corrige la variable x (en minúsculas)
            }

            // Finaliza el programa
            // Muestra un mensaje antes de terminar
            Console.WriteLine("\nPrograma finalizado.");

            // Evita que la consola se cierre inmediatamente
            Console.WriteLine("Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}


