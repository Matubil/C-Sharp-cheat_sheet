using System;
using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string Email { get; set; }

        public decimal Balance { get; set; }
    }
}

/*En este ejemplo, hemos creado una clase de entidad llamada Customer que representa un objeto "Cliente". La clase tiene las siguientes características:
    
    -La propiedad CustomerId se ha definido como la clave primaria utilizando el atributo [Key].
    -La propiedad Name es obligatoria y se ha limitado a una longitud máxima de 50 caracteres utilizando los atributos [Required] y [StringLength(50)].
    -La propiedad BirthDate es obligatoria y representa la fecha de nacimiento del cliente.
    -La propiedad Email es opcional y puede contener la dirección de correo electrónico del cliente.
    -La propiedad Balance representa el saldo del cliente y se ha definido como un tipo de datos decimal.*/
    