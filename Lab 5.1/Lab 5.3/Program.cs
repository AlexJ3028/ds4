using System;

namespace Lab53
{
    class Program
    {
        string[] frutas = { "manzana", "plátano", "naranja" };

        // El método Main es el punto de entrada
        static void Main(string[] args)
        {
            // Instancia de la clase Program para acceder al array frutas
            Program program = new Program();

            // Bucle foreach correctamente estructurado dentro de un método
            foreach (string fruta in program.frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.ReadKey();  // Pausar para que la consola no cierre inmediatamente
        }
    }
}
