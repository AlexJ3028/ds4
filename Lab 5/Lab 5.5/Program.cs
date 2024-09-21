using System;
using System.Collections.Generic;

namespace Lab55
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    class Program
    {
        static void Main(string[] args) // Método Main agregado
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante { Nombre = "Ana", Edad = 12 },
                new Estudiante { Nombre = "Juan", Edad = 10 },
                new Estudiante { Nombre = "Sofia", Edad = 11 }
            };

            foreach (Estudiante estudiante in estudiantes)
            {
                // Corregido el acceso a 'Edad' y a 'Nombre'
                Console.WriteLine("Nombre: " + estudiante.Nombre + ", Edad: " + estudiante.Edad);
            }
        }
    }
}
