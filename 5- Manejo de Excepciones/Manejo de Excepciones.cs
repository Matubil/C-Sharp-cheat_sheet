try
{
    // Bloque de código donde se puede producir una excepción
    int dividendo = 10;
    int divisor = 0;
    int resultado = dividendo / divisor;
    Console.WriteLine(resultado);
}
catch (DivideByZeroException ex)
{
    // Manejo de la excepción DivideByZeroException
    Console.WriteLine("Error: División por cero");
}
catch (Exception ex)
{
    // Manejo de excepciones generales
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    // Bloque de código que se ejecuta siempre, independientemente de si se produce una excepción o no
    Console.WriteLine("Finalizando programa");
}
