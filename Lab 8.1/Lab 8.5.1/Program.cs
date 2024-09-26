using System;

public partial class Coordenadas
{
    private int x;
    private int y;

    public Coordenadas(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public partial class Coordenadas
{
    public void verCoordenadas()
    {
        Console.WriteLine("Coordenadas: {0}, {1}", x, y);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // Se corrigió el nombre de la clase en la creación del objeto
        Coordenadas misCoords = new Coordenadas(10, 15);

        // Se corrigió el uso del método con la correcta capitalización
        misCoords.verCoordenadas();
    }
}

