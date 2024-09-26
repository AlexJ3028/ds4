using System;

class Persona
{
    public string Nombre;
    public int Edad;  // Cambié a mayúscula para mantener consistencia
    public string NIF;

    public void Cumpleaños()  // Cerré el paréntesis
    {
        Edad++;  // Incrementa la edad
    }

    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }
}

class Trabajador : Persona  // Cambié a mayúscula la clase 'Trabajador'
{
    public int Sueldo;

    public Trabajador(string nombre, int edad, string nif, int sueldo)
        : base(nombre, edad, nif)
    {
        Sueldo = sueldo;  // Cambié 'sueldo = sueldo;' para asignar correctamente el parámetro
    }
}

class Program
{
    public static void Main()
    {
        Trabajador p = new Trabajador("Josan", 22, "77588260-Z", 100000);
        Console.WriteLine("Nombre = " + p.Nombre);  // Cambié a 'WriteLine' y variable 'Nombre'
        Console.WriteLine("Edad = " + p.Edad);  // 'Edad' es la variable correcta
        Console.WriteLine("NIF = " + p.NIF);
        Console.WriteLine("Sueldo = " + p.Sueldo);  // 'Sueldo' es la variable correcta
        Console.ReadKey();  // Cambié a 'ReadKey'
    }
}
