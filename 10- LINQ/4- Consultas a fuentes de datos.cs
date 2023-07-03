/* Las consultas en LINQ se realizan sobre fuentes de datos, que pueden ser cualquier tipo de objeto que implemente la
 interfaz IEnumerable<T>. Esto incluye arreglos, listas, diccionarios, colecciones personalizadas, y más.*/

List<Persona> personas = ObtenerListaDePersonas();

var personasMayoresDeEdad = from persona in personas
                            where persona.Edad >= 18
                            select persona;

foreach (var persona in personasMayoresDeEdad)
{
    Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
}
