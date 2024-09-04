// Ejercicio 2: calculo del area de un circulo, agregando el metodo calculoArea a la clase creada en el ejercicio anterior, los calculos para calcular el area de circulo son leidos por teclado.
using System;

namespace Area_circulo 
{
    class Program
    {
        static void Main(string[] args)
        {

            // Solicitar al usuario que ingrese el radio del círculo
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Llamar al método CalculoArea y mostrar el resultado
            double areaCirculo = CalculosMatematicos.CalculoArea(radio);
            Console.WriteLine("El área del círculo con radio {radio} es: {areaCirculo}");
        }
    }

    class CalculosMatematicos
    {
        
        // Método estático para calcular el área de un círculo
        public static double CalculoArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
