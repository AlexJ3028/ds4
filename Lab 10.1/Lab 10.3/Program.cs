using System.Reflection;

Module Peso
    Sub Main()
        ' Declaración de variables
        Dim M As Double
        Dim g As Double
        Dim p As Double

        ' Asignar valor a la gravedad
        g = 9.8

        ' Solicitar al usuario que ingrese la masa del objeto
        Console.Write("Ingrese la masa del objeto: ")

        ' Leer la masa y convertir a tipo Double
        M = Convert.ToDouble(Console.ReadLine())

        ' Calcular el peso usando la fórmula p = m * g
        p = M * g

        ' Mostrar el resultado del peso calculado
        Console.WriteLine("Peso del objeto: {0}", p)

        ' Esperar a que el usuario presione una tecla para cerrar
        Console.ReadKey()
    End Sub
End Module

