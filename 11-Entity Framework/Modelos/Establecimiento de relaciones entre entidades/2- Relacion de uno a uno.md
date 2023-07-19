En una relación de uno a uno, una entidad se relaciona con otra entidad de tal manera que cada instancia de la entidad principal tiene asociada una única instancia de la entidad relacionada.

Por ejemplo, consideremos las entidades "Usuario" y "Perfil", donde cada usuario tiene un único perfil asociado. Puedes establecer esta relación de uno a uno utilizando propiedades de navegación en ambas entidades.

```csharp
public class Usuario
{
    public int UsuarioId { get; set; }
    public string Nombre { get; set; }

    public Perfil Perfil { get; set; }
}

public class Perfil
{
    public int PerfilId { get; set; }
    public string Descripcion { get; set; }

    public Usuario Usuario { get; set; }
}
```
En el ejemplo anterior, la clase Usuario tiene una propiedad de navegación Perfil y la clase Perfil tiene una propiedad de navegación Usuario. Esto establece una relación de uno a uno entre las entidades.