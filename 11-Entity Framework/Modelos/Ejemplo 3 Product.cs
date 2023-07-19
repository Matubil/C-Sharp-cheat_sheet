using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourNamespace.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

/*En este ejemplo, hemos creado una clase de entidad llamada Product que representa un objeto "Producto". La clase tiene las siguientes características:

    -La propiedad ProductId se ha definido como la clave primaria utilizando el atributo [Key].
    -La propiedad Name es obligatoria y se ha limitado a una longitud máxima de 100 caracteres utilizando los atributos [Required] y [StringLength(100)].
    -La propiedad Price representa el precio del producto y está decorada con el atributo [Column(TypeName = "decimal(18, 2)")] para especificar su tipo de datos en la base de datos.
    -Hemos establecido una relación con la entidad Category. La propiedad CategoryId es la clave externa que hace referencia a la entidad Category, y la propiedad Category es una navegación que permite acceder al objeto Category asociado al producto.*/