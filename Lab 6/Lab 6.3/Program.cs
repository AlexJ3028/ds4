using System;

namespace Lab63
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] MyNumbers = { 1, 2, 3 };
                Console.WriteLine("Algo salio mal, valide el indice del arreglo");
            }
            finally
            {
                Console.WriteLine("continuacion de la aplicacion, luego del bloque try/catch");
            }

        }
    }
    
