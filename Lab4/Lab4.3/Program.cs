using System;

namespace Lab43
{
    class Program
    {
        // Inicializa el programa
        static void Main(string[] args)
        {
            // Muestra un mensaje al iniciar el programa
            Console.WriteLine("Programa iniciado.");

            int suma, cant, valor, promedio;
            string linea;

            suma = 0;
            cant = 0;

            do
            {
                // Solicita al usuario que ingrese un valor
                Console.Write("Ingrese un número (0 para finalizar): ");
                linea = Console.ReadLine();

                // Convierte la entrada del usuario en un número entero
                valor = int.Parse(linea);

                // Si el valor es diferente de 0, se suma y se incrementa el contador
                if (valor != 0)
                {
                    suma = suma + valor;
                    cant++;
                }
            }
            while (valor != 0);

            // Si se ingresaron números, calcula el promedio
            if (cant != 0)
            {
                promedio = suma / cant;
                Console.WriteLine("El promedio de los valores ingresados es: " + promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron valores.");
            }

            // Evita que la consola se cierre inmediatamente
            Console.WriteLine("\nPrograma finalizado.");
            Console.ReadKey();
        }
    }
}


