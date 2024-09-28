using System;

namespace TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese los tres lados del triángulo
            Console.WriteLine("Ingrese el valor del primer lado del triángulo:");
            double lado1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo lado del triángulo:");
            double lado2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del tercer lado del triángulo:");
            double lado3 = double.Parse(Console.ReadLine());

            // Verificar si los lados pueden formar un triángulo válido
            if (EsTrianguloValido(lado1, lado2, lado3))
            {
                // Determinar el tipo de triángulo
                string tipoTriangulo = TipoDeTriangulo(lado1, lado2, lado3);
                Console.WriteLine($"El triángulo con lados {lado1}, {lado2} y {lado3} es un triángulo {tipoTriangulo}.");
            }
            else
            {
                Console.WriteLine("Los valores ingresados no forman un triángulo válido.");
            }
        }

        // Método para verificar si los tres lados forman un triángulo válido
        static bool EsTrianguloValido(double lado1, double lado2, double lado3)
        {
            // La suma de dos lados cualquiera debe ser mayor que el tercer lado
            return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1);
        }

        // Método para determinar el tipo de triángulo según sus lados
        static string TipoDeTriangulo(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "equilátero"; // Los tres lados son iguales
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                return "isósceles"; // Dos lados son iguales
            }
            else
            {
                return "escaleno"; // Todos los lados son diferentes
            }
        }
    }
}

