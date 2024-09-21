using System;

namespace Lab64
{
    class Program
    {
        // Método que verifica la edad
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                // Corregido el nombre de la excepción y el mensaje.
                throw new ArithmeticException("Acceso denegado - no cumple con el criterio de edad");
            }
            else
            {
                Console.WriteLine("Acceso concedido");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                // Se llama al método CheckAge con una edad
                CheckAge(15);
            }
            catch (ArithmeticException e)
            {
                // Captura y muestra la excepción en caso de que ocurra
                Console.WriteLine(e.Message);
            }
        }
    }
}


