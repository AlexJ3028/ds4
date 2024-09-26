using System;

interface ITemplate // Nombre de la interfaz debería iniciar con mayúscula por convención
{
    void PonerVariable(string nombre, string var); // Quitado 'public', ya que no es necesario en una interfaz
    void VerHtml(string template);
}

class Template : ITemplate
{
    public void PonerVariable(string nombre, string var)
    {
        Console.WriteLine($"Método poner variable {nombre} : {var}"); // Usando interpolación de cadenas con '$'
    }

    public void VerHtml(string template)
    {
        Console.WriteLine(template);
    }
}

internal class Program
{
    private static void Main(string[] args) // El método Main debe ir con 'M' mayúscula
    {
        Template temp1 = new Template(); // Corregido el nombre de la clase a 'Template'
        temp1.PonerVariable("var1", "valor1");
        temp1.PonerVariable("var2", "valor2");
        temp1.PonerVariable("var3", "valor3");
        temp1.VerHtml("<br> Texto de prueba </br>");
    }
}
