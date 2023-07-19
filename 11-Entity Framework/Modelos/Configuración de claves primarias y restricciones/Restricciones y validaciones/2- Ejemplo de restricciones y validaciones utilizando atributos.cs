public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [Required] // Atributo [Required] para indicar que la propiedad es obligatoria
    [StringLength(50)] // Atributo [StringLength] para limitar la longitud de la cadena
    public string Name { get; set; }

    [Range(0, 100)] // Atributo [Range] para establecer un rango válido
    public int Age { get; set; }
}

/*En el ejemplo anterior, hemos utilizado los atributos [Required], [StringLength] y [Range] para aplicar restricciones y validaciones en las propiedades Name y Age de la clase Customer.*/