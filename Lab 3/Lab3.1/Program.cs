// Ejercicio 1: el usuario ingresa 2 numeros y el resultado muestra (a+b)*(a-b), la operacion debe estar bajo el metodo calcular de la clase calculos matematicos y el programa principal bajo la clase program.
using System;

namespace Resultadode(a+b)*(a-b)
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese los valores de a y b
            Console.WriteLine("Ingrese el valor de a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de b:");
            int b = Convert.ToInt32(Console.ReadLine());

            // Llamar al método Calcular y mostrar el resultado
            int resultado = CalculosMatematicos.Calcular(a, b);
            Console.WriteLine($"El resultado de (a + b) * (a - b) es: {resultado}");
        }
    }

    class CalculosMatematicos
    {
        // Método estático para realizar la operación (a + b) * (a - b)
        public static int Calcular(int a, int b)
        {
            return (a + b) * (a - b);
        }
    }
}


