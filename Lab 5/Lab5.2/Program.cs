using System;

namespace Lab52
{
    class Program
    {
        private int[,] mat;

        // Método para ingresar datos en la matriz
        public void Ingresar()
        {
            mat = new int[3, 4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write("Ingrese posición [" + (f + 1) + "," + (c + 1) + "]: ");
                    string linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);  // Corregido Parse
                }
            }
        }

        // Método para imprimir los datos de la matriz
        public void Imprimir()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(mat[f, c] + " ");  // Corregido acceso a la matriz
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        // Método Main, punto de entrada del programa
        static void Main(string[] args)
        {
            Program programa = new Program();
            programa.Ingresar();
            programa.Imprimir();  // Llamada al método Imprimir
        }
    }
}
