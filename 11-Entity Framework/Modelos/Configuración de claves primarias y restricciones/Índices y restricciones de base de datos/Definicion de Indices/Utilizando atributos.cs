using System.ComponentModel.DataAnnotations.Schema;

public class Customer
{
    public int CustomerId { get; set; }

    [Index("IX_CustomerName", IsUnique = true)]
    public string Name { get; set; }

    // Resto de propiedades
}

/*En este ejemplo, hemos utilizado el atributo [Index] para definir un índice en la propiedad Name de la clase Customer. El parámetro IsUnique se establece en true para indicar que el índice debe ser único.*/