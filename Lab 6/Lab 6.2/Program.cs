using System;

namespace Lab62
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variable con punto y coma
            int num;

            // Solicitar el número al usuario
            Console.WriteLine("Digite el número deseado:");

            try
            {
                // Conversión de entrada a número entero con manejo de excepciones
                num = int.Parse(Console.ReadLine()); // Cambio a int.Parse
            }
            catch (FormatException ex)  // Corrección de 'FormaException' a 'FormatException'
            {
                Console.WriteLine("No se ha introducido un dígito válido.");
                num = -1; // Valor por defecto en caso de error
            }
            catch (OverflowException ex)  // Mantener el manejo de excepción de desbordamiento
            {
                Console.WriteLine("El número introducido es muy grande.");
                num = -1; // Valor por defecto en caso de error
            }

            // Mostrar el valor del número o -1 si hubo un error
            Console.WriteLine(num);
        }
    }
}
