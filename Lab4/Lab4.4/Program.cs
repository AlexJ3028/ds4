using System;

namespace Lab44
{
    class Program
    {
        // Inicializa el programa
        static void Main(string[] args)
        {
            // Muestra un mensaje al iniciar el programa
            Console.WriteLine("Programa iniciado.");

            // Solicita la nota del estudiante
            Console.WriteLine("Ingrese la nota del estudiante:");
            float score = float.Parse(Console.ReadLine());

            // Verifica si la nota es mayor o igual a 70 para aprobar
            if (score >= 70)
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score}. Ha aprobado.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score}. Ha reprobado, debe repetir.");
            }

            // Evita que la consola se cierre inmediatamente
            Console.WriteLine("\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}
