using System;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

        // Relación con la entidad Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}

/*En este ejemplo, hemos creado una clase de entidad llamada Order que representa un objeto "Orden". La clase tiene las siguientes características:

    -La propiedad OrderId se ha definido como la clave primaria utilizando el atributo [Key].
    -La propiedad OrderDate representa la fecha de la orden y es obligatoria.
    -La propiedad TotalAmount representa el monto total de la orden y es de tipo decimal.
    -Hemos establecido una relación con la entidad Customer. La propiedad CustomerId es la clave externa que hace referencia a la entidad Customer, y la propiedad Customer es una navegación que permite acceder al objeto Customer asociado a la orden.*/