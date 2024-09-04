// Ejercicio 4: calcular el area de un rectangulo con los valores ingresados por el usuario.
using System;

namespace Area_Rectangulo

{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el ancho del rectángulo
            Console.WriteLine("Ingrese el ancho del rectángulo:");
            double ancho = Convert.ToDouble(Console.ReadLine());

            // Solicitar al usuario que ingrese la altura del rectángulo
            Console.WriteLine("Ingrese la altura del rectángulo:");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Calcular el área del rectángulo
            double areaRectangulo = CalculosMatematicos.CalculoAreaRectangulo(ancho, altura);
            Console.WriteLine($"El área del rectángulo es: {areaRectangulo}");
        }
    }

    class CalculosMatematicos
    {
        // Método estático para calcular el área de un rectángulo
        public static double CalculoAreaRectangulo(double ancho, double altura)
        {
            return ancho * altura;
        }
    }
}

