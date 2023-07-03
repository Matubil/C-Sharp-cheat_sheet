namespace MiNamespace
{
    // Declaración de clase
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Creación de objeto
            Persona persona = new Persona()
            {
                Nombre = "Juan",
                Edad = 30
            };

            // Resto del código
        }
    }
}
