
Imports System.Globalization

' Definición de la clase Perro
Public Class Perro
    Public nombre As String
    Public raza As String
    Public altura As String

    ' Método para simular la acción de comer
    Public Function Comer(carne As String) As String
        Return nombre & " mide " & altura & " y comerá " & carne
    End Function

    ' Método vacío para dormir
    Public Sub Dormir()
    End Sub

    ' Método vacío para ladrar
    Public Sub Ladrar()
    End Sub

    ' Función para calcular el costo de algo con impuesto
    Public Function CalcularCosto(costo As Double, impuesto As Double) As Double
        Dim precioTotal As Double
        precioTotal = costo + (costo * impuesto)
        Return precioTotal
    End Function

    ' Constructor vacío
    Public Sub New()
    End Sub

    ' Constructor con parámetros
    Public Sub New(nombre As String, raza As String, altura As String)
        Me.nombre = nombre
        Me.raza = raza
        Me.altura = altura
    End Sub
End Class

' Programa principal
Module Program
    Public Sub Main(Args() As String)
        ' Crear una instancia de la clase Perro
        Dim perrito As New Perro()
        perrito.nombre = "Chizu"
        perrito.raza = "Pastor Alemán"
        perrito.altura = "0.70 cm"
        
        ' Llamada al método Comer y salida en consola
        Console.WriteLine(perrito.Comer("carne"))

        ' Otra instancia con valores asignados
        Dim perrito2 As New Perro()
        perrito2.nombre = "Lazy"
        perrito2.raza = "Beagle"
        perrito2.altura = "0.60 cm"
        
        Console.WriteLine(perrito2.Comer("pollo"))

        ' Instancia creada con el constructor con parámetros
        Dim perrito3 As New Perro("Peluchin", "Poodle", "0.50 cm")
        Console.WriteLine(perrito3.Comer("pan"))
    End Sub
End Module
