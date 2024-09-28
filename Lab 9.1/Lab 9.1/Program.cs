using System;

namespace PaymentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paso 1: Solicitar al usuario el precio del producto
            decimal precioProducto = ObtenerPrecioPositivo();

            // Paso 2: Preguntar la forma de pago (efectivo o tarjeta)
            Console.WriteLine("¿Desea pagar en efectivo o con tarjeta? (Escriba 'efectivo' o 'tarjeta'):");
            string formaDePago = Console.ReadLine().ToLower(); // Convertir a minúsculas para facilitar comparación

            // Paso 3: Validar la forma de pago ingresada
            while (formaDePago != "efectivo" && formaDePago != "tarjeta")
            {
                Console.WriteLine("Forma de pago no válida. Por favor, ingrese 'efectivo' o 'tarjeta'.");
                formaDePago = Console.ReadLine().ToLower();
            }

            // Paso 4: Si la forma de pago es con tarjeta, solicitar el número de cuenta
            if (formaDePago == "tarjeta")
            {
                string numeroTarjeta = ObtenerNumeroDeTarjeta();
                Console.WriteLine($"Número de tarjeta ingresado correctamente: {numeroTarjeta}");
            }
            else
            {
                // Pago en efectivo
                Console.WriteLine("Pago en efectivo seleccionado.");
            }

            // Paso 5: Mostrar mensaje final con el precio total
            Console.WriteLine($"El precio total del producto es: ${precioProducto}");
            Console.ReadLine();
        }

        // Método para obtener el precio positivo del producto
        static decimal ObtenerPrecioPositivo()
        {
            decimal precio;
            Console.WriteLine("Por favor, ingrese el precio del producto (solo valores positivos):");

            // Validar que el usuario ingrese un valor positivo y numérico
            while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
            {
                Console.WriteLine("Valor no válido. Por favor, ingrese un precio positivo:");
            }
            return precio;
        }

        // Método para obtener un número de tarjeta de 16 dígitos válido
        static string ObtenerNumeroDeTarjeta()
        {
            string numeroTarjeta;
            Console.WriteLine("Por favor, ingrese el número de la tarjeta (16 dígitos):");

            // Validar que el usuario ingrese exactamente 16 dígitos
            numeroTarjeta = Console.ReadLine();
            while (numeroTarjeta.Length != 16 || !EsNumeroValido(numeroTarjeta))
            {
                Console.WriteLine("Número de tarjeta no válido. Ingrese un número de 16 dígitos:");
                numeroTarjeta = Console.ReadLine();
            }
            return numeroTarjeta;
        }

        // Método auxiliar para validar que el string contenga solo dígitos
        static bool EsNumeroValido(string numero)
        {
            foreach (char c in numero)
            {
                if (!char.IsDigit(c)) return false; // Si encuentra un carácter no numérico, retorna false
            }
            return true;
        }
    }
}

