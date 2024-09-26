using System;

internal class Program  // Cambio a PascalCase para el nombre de la clase
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Suma(1.0, 2.2));  // Llama al método que suma números decimales
    }

    // Método sobrecargado para sumar dos enteros
    static int Suma(int x, int y)  // Cambio el nombre a Suma en mayúscula para consistencia
    {
        return x + y;
    }

    // Método sobrecargado para sumar dos números decimales
    static double Suma(double x, double y)
    {
        return x + y;
    }

    // Método sobrecargado para sumar dos números largos
    static long Suma(long x, long y)
    {
        return x + y;
    }
}

