Las anotaciones de atributos te permiten personalizar el mapeo entre las propiedades de las entidades y las columnas de la base de datos. A continuación, se presentan algunas anotaciones de atributos comunes que puedes utilizar:

[Table("NombreTabla")]: Se utiliza para especificar el nombre de la tabla en la base de datos a la que está mapeada la entidad.

[Column("NombreColumna")]: Se utiliza para especificar el nombre de la columna en la base de datos a la que está mapeada una propiedad.

[ForeignKey("NombrePropiedadRelacionada")]: Se utiliza para establecer una clave externa y especificar la propiedad de navegación relacionada.

[NotMapped]: Se utiliza para indicar que una propiedad no debe ser mapeada a una columna de la base de datos.

Aquí tienes un ejemplo de cómo utilizar estas anotaciones de atributos:

```csharp

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Clientes")]
public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [Column("NombreCliente")]
    public string Name { get; set; }

    [ForeignKey("Categoria")]
    public int CategoryId { get; set; }
    public Category Categoria { get; set; }

    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";

    // Resto de propiedades
}

```

En el ejemplo anterior, hemos utilizado las anotaciones de atributos [Table], [Column], [ForeignKey] y [NotMapped] para personalizar el mapeo de propiedades en la entidad Customer. Hemos especificado el nombre de la tabla como "Clientes", el nombre de la columna como "NombreCliente", la clave externa a la propiedad Categoria y hemos indicado que la propiedad FullName no debe ser mapeada a una columna de la base de datos.