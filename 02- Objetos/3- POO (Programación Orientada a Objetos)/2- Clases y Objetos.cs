using System;

namespace MiNamespace
{
    public class Persona
    {
        // Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Método
        public void Saludar()
        {
            Console.WriteLine($"¡Hola! Mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Creación de un objeto
            Persona persona = new Persona("Juan", 30);
            persona.Saludar();
        }
    }
}
