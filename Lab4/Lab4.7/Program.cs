using System;

namespace Lab47
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 70;
            double numeroDos = 67.89;
            double numeroTres = 67.89;

            // Llama al método Suma con dos argumentos
            Console.WriteLine(Suma(numeroUno, numeroDos));

            // Llama al método Suma con tres argumentos
            Console.WriteLine(Suma(numeroUno, numeroDos, numeroTres));
        }

        // Método que suma dos o tres números
        static double Suma(int x, double y, double z = 0)
        {
            return x + y + z;
        }
    }
}


