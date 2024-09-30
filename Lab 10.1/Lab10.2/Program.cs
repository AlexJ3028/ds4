using System.Reflection;

Module Area
    ' Declaración de variables
    Dim radio As Single
    Dim area As Single
    Dim circunferencia As Single
    Const pi As Single = 3.1415926

    Sub Main()
        ' Solicitar al usuario que ingrese el radio
        Console.WriteLine("Ingrese el radio: ")
        ' Leer y convertir el valor del radio
        radio = Convert.ToSingle(Console.ReadLine())

        ' Calcular el área y la circunferencia
        area = pi * radio ^ 2
        circunferencia = 2 * pi * radio

        ' Mostrar los resultados
        Console.WriteLine("El área es: {0}", area)
        Console.WriteLine("La circunferencia es: {0}", circunferencia)

        ' Esperar a que el usuario presione una tecla para cerrar
        Console.ReadKey()
    End Sub

End Module

