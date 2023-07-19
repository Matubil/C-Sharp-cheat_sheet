using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}

/*En este ejemplo, hemos creado una clase de entidad llamada Category que representa un objeto "Categoría". La clase tiene las siguientes características:

    -La propiedad CategoryId se ha definido como la clave primaria utilizando el atributo [Key].
    -La propiedad Name es obligatoria y se ha limitado a una longitud máxima de 50 caracteres utilizando los atributos [Required] y [StringLength(50)].
    -La propiedad Products representa una lista de productos asociados a la categoría. Aquí, utilizamos la relación de navegación de uno a muchos, donde una categoría puede tener varios productos.*/