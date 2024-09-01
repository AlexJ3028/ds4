using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(String[] args)
        {
            Client client = new Client();
            // Variables de instancia de clase (ejemplos).
            client.FirstName = "su_nombre";
            client.LastName = "su_apellido";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }

    public class Client
    {
        // Declaración de variables de instancia en clases.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}

