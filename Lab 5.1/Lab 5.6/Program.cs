using System;
using System.Collections.Generic; // Importar para usar Dictionary

namespace Lab56
{
    class Program
    {
        static void Main(string[] args) // Método Main agregado
        {
            // Inicializamos el diccionario
            Dictionary<string, string> paisesyCapitales = new Dictionary<string, string>
            {
                {"Francia", "Paris"},
                {"España", "Madrid"},
                {"Italia", "Roma"}
            };

            // Bucle foreach dentro del método Main
            foreach (KeyValuePair<string, string> par in paisesyCapitales)
            {
                // Corregido Key y Value con mayúscula inicial
                Console.WriteLine("La capital de " + par.Key + " es " + par.Value + ".");
            }
        }
    }
}

