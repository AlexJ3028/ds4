using System;

public class Empleado
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
}

public class CuentaBancaria
{
    private decimal _saldo;
    public decimal Saldo
    {
        get { return _saldo; }
        set
        {
            if (value >= 0)
                _saldo = value;
            else
                throw new ArgumentException("El saldo no puede ser negativo.");
        }
    }
}

public class Cobertura
{
    private double radio;

    // Constructor de la clase Cobertura
    public Cobertura(double radio)
    {
        this.radio = radio;
    }

    // Propiedad para obtener el valor del radio
    public double Radio
    {
        get { return radio; }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // Creación del objeto Empleado y asignación del nombre
        Empleado empleado = new Empleado();
        empleado.Nombre = "John Doe";
        Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");

        // Creación del objeto CuentaBancaria y asignación del saldo
        CuentaBancaria cta = new CuentaBancaria();
        cta.Saldo = 100;
        Console.WriteLine($"El saldo de la cuenta bancaria es: {cta.Saldo}");

        // Creación del objeto Cobertura con un valor de radio
        Cobertura c = new Cobertura(5);
        Console.WriteLine($"Cobertura con un radio de: {c.Radio}");
    }
}
