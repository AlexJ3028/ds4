using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrió la aplicación");
    }
}

class ClaseBase // Quitado el modificador 'sealed' para permitir herencia
{
    public void Test()
    {
        Console.WriteLine("Test method in ClaseBase");
    }

    public void MoreTesting() // Corregido el nombre del método
    {
        Console.WriteLine("MoreTesting method in ClaseBase");
    }
}

// Ahora ClaseHijo puede heredar correctamente de ClaseBase
class ClaseHijo : ClaseBase
{
    public void Demo()
    {
        Console.WriteLine("Demo method in ClaseHijo");
    }
}
