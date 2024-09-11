using System;

namespace Lab46
{
    class Program
    {
        // Inicializa el programa
        static void Main(string[] args)
        {
            // Muestra un mensaje al iniciar el programa
            Console.WriteLine("Programa iniciado.");

            // Solicita el radio del círculo
            Console.WriteLine("Digite el radio del círculo:");
            double radio = double.Parse(Console.ReadLine());

            // Calcula el área del círculo
            double area = Math.Pow(radio, 2) * Math.PI;

            // Muestra el área del círculo
            Console.WriteLine($"El área del círculo es: {area}.");
            Console.ReadKey();

            // Evita que la consola se cierre inmediatamente
            Console.WriteLine("\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}
