using System;
using System.Collections.Generic;

namespace GeneradorAleatorio
{
    // Clase que contiene métodos para generar números aleatorios.
    class Aleatorios
    {
        // Atributo de la clase para la generación de números aleatorios.
        private Random random;

        // Constructor que inicializa el objeto Random.
        public Aleatorios()
        {
            random = new Random();
        }

        // Método para generar un número aleatorio entre dos límites especificados.
        public int GenerarNumero(int limiteInferior, int limiteSuperior)
        {
            return random.Next(limiteInferior, limiteSuperior + 1); // Genera un número entre el límite inferior y superior (incluye superior).
        }

        // Método para generar un arreglo de números aleatorios entre dos límites especificados.
        public int[] GenerarArreglo(int limiteInferior, int limiteSuperior, int tamanioArreglo)
        {
            int[] arregloNumeros = new int[tamanioArreglo]; // Crea un arreglo con el tamaño especificado.

            for (int i = 0; i < tamanioArreglo; i++)
            {
                arregloNumeros[i] = GenerarNumero(limiteInferior, limiteSuperior); // Asigna un número aleatorio a cada posición del arreglo.
            }

            return arregloNumeros; // Retorna el arreglo generado.
        }

        // Método para generar un arreglo de números aleatorios **no repetidos** entre dos límites especificados.
        public int[] GenerarArregloNoRepetido(int limiteInferior, int limiteSuperior, int tamanioArreglo)
        {
            // Validación: si el tamaño del arreglo es mayor al rango de números disponibles, lanzar un error.
            if (tamanioArreglo > (limiteSuperior - limiteInferior + 1))
            {
                throw new ArgumentException("El tamaño del arreglo no puede ser mayor que la cantidad de números únicos en el rango especificado.");
            }

            HashSet<int> numerosGenerados = new HashSet<int>(); // Usamos un conjunto para almacenar números únicos.
            int[] arregloNoRepetido = new int[tamanioArreglo]; // Arreglo para almacenar los números generados.

            // Generar números únicos hasta que se complete el tamaño del arreglo.
            for (int i = 0; i < tamanioArreglo; i++)
            {
                int nuevoNumero;
                // Generar números aleatorios hasta encontrar uno que no se haya generado antes.
                do
                {
                    nuevoNumero = GenerarNumero(limiteInferior, limiteSuperior);
                } while (numerosGenerados.Contains(nuevoNumero)); // Repetir hasta que el número sea único.

                // Agregar el número al conjunto de números generados.
                numerosGenerados.Add(nuevoNumero);
                arregloNoRepetido[i] = nuevoNumero; // Asignar el número al arreglo.
            }

            return arregloNoRepetido; // Retornar el arreglo de números únicos.
        }
    }

    // Clase principal para probar la funcionalidad de la clase Aleatorios.
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar la clase Aleatorios.
            Aleatorios generador = new Aleatorios();

            // Pedir al usuario los límites para generar el número aleatorio.
            Console.WriteLine("Ingrese el límite inferior para generar los números aleatorios:");
            int limiteInferior = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el límite superior para generar los números aleatorios:");
            int limiteSuperior = int.Parse(Console.ReadLine());

            // Generar un solo número aleatorio entre los límites especificados.
            int numeroGenerado = generador.GenerarNumero(limiteInferior, limiteSuperior);
            Console.WriteLine($"Número aleatorio generado entre {limiteInferior} y {limiteSuperior}: {numeroGenerado}");

            // Pedir el tamaño del arreglo al usuario.
            Console.WriteLine("Ingrese el tamaño del arreglo de números aleatorios:");
            int tamanioArreglo = int.Parse(Console.ReadLine());

            // Generar un arreglo de números aleatorios con los límites y tamaño especificados.
            int[] arregloAleatorio = generador.GenerarArreglo(limiteInferior, limiteSuperior, tamanioArreglo);

            // Mostrar el arreglo generado.
            Console.WriteLine("Arreglo de números aleatorios generado:");
            foreach (int numero in arregloAleatorio)
            {
                Console.Write(numero + " "); // Imprime cada número del arreglo.
            }

            Console.WriteLine(); // Espacio final.

            // Generar un arreglo de números **no repetidos** con los mismos límites y tamaño especificados.
            Console.WriteLine("Arreglo de números aleatorios no repetidos:");
            int[] arregloNoRepetido = generador.GenerarArregloNoRepetido(limiteInferior, limiteSuperior, tamanioArreglo);

            // Mostrar el arreglo generado.
            foreach (int numero in arregloNoRepetido)
            {
                Console.Write(numero + " "); // Imprime cada número único del arreglo.
            }

            Console.WriteLine(); // Espacio final.
        }
    }
}
