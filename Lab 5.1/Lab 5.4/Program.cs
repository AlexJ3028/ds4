using System;
using System.Collections.Generic;

namespace Lab54
{
    class Program
    {
        static void Main(string[] args) // Método Main agregado para ejecutar el código
        {
            List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };
            int suma = 0;

            // Bucle foreach correctamente colocado dentro del método Main
            foreach (int calificacion in calificaciones)
            {
                suma += calificacion;
            }

            // Se corrige la fórmula para calcular el promedio
            double promedio = suma / (double)calificaciones.Count;

            // Se corrige Console.WriteLine
            Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
        }
    }
}

