using System.ComponentModel.DataAnnotations;

public class Customer
{
    public int CustomerId { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    // Resto de propiedades
}

/*En este ejemplo, hemos utilizado los atributos [Required] y [StringLength] para definir restricciones en la propiedad Name de la clase Customer. El atributo [Required] indica que la propiedad es obligatoria y el atributo [StringLength] establece una longitud máxima de 50 caracteres.*/