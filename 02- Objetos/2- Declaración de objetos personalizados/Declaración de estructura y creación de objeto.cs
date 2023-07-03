namespace MiNamespace
{
    // Declaración de estructura
    public struct Punto
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Creación de objeto
            Punto punto = new Punto();
            punto.X = 10;
            punto.Y = 20;

            // Resto del código
        }
    }
}
