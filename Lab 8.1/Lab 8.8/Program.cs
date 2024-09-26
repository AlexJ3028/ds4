using System;

abstract class ClaseAbstracta
{
    protected abstract string TomarValor(); // Cambiado a 'protected' y nombre corregido
    public abstract string PrefixValor(string prefix); // Corregido 'prefixValor'

    public void PrintOut() // Corregido nombre del método
    {
        Console.WriteLine(TomarValor()); // Corregido 'WriteLine'
    }
}

class ClaseConcreta1 : ClaseAbstracta
{
    protected override string TomarValor()
    {
        return "ClaseConcreta1";
    }

    public override string PrefixValor(string prefix)
    {
        return $"{prefix}ClaseConcreta1"; // Usando interpolación de cadenas
    }
}

class ClaseConcreta2 : ClaseAbstracta
{
    protected override string TomarValor()
    {
        return "ClaseConcreta2";
    }

    public override string PrefixValor(string prefix)
    {
        return $"{prefix}ClaseConcreta2"; // Usando interpolación de cadenas
    }
}

internal class Program // Corregido nombre de la clase a 'Program'
{
    private static void Main(string[] args) // Corregido 'Main'
    {
        ClaseConcreta1 concreta1 = new ClaseConcreta1();
        concreta1.PrintOut();
        Console.WriteLine(concreta1.PrefixValor("ES_")); // Corregido 'prefixValor'

        ClaseConcreta2 concreta2 = new ClaseConcreta2(); // Corregido instancia de 'ClaseConcreta2'
        concreta2.PrintOut();
        Console.WriteLine(concreta2.PrefixValor("ES_")); // Corregido 'prefixValor'
    }
}



