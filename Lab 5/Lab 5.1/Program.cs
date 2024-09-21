using System;

namespace Lab51
{
    class Program
    {
        private int[] sueldos;  // Mueve la declaración de sueldos dentro de la clase

        // Método para cargar los sueldos
        public void Cargar()
        {
            sueldos = new int[5];  // El arreglo debe tener tamaño 5 para almacenar 5 sueldos
            for (int f = 0; f < 5; f++)  // Inicia el índice en 0, termina en 4
            {
                Console.Write("Ingrese el sueldo del operario " + (f + 1) + ": ");
                string linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        // Método para imprimir los sueldos
        public void Imprimir()
        {
            Console.WriteLine("Los 5 sueldos de los operarios:");
            for (int f = 0; f < 5; f++)  // Recorre el arreglo desde 0 hasta 4
            {
                Console.Write("[" + sueldos[f] + "] ");
            }
            Console.WriteLine();
        }

        // Método Main, que es el punto de entrada del programa
        static void Main(string[] args)
        {
            Program pv = new Program();  // Cambié PruebaVector1 por Program
            pv.Cargar();
            pv.Imprimir();

            // Evita que la consola se cierre inmediatamente
            Console.WriteLine("\nPrograma finalizado. Presiona cualquier tecla para salir.");
            Console.ReadKey();  // Mueve ReadKey aquí para detener la consola
        }
    }
}



