En una relación de uno a muchos, una entidad se relaciona con varias instancias de otra entidad. Cada instancia de la entidad principal puede tener varias instancias de la entidad relacionada asociadas a ella.

Por ejemplo, consideremos las entidades "Departamento" y "Empleado", donde un departamento puede tener varios empleados asociados. Puedes establecer esta relación de uno a muchos utilizando una colección de la entidad relacionada como una propiedad de navegación en la entidad principal.

```csharp
public class Departamento
{
    public int DepartamentoId { get; set; }
    public string Nombre { get; set; }

    public ICollection<Empleado> Empleados { get; set; }
}

public class Empleado
{
    public int EmpleadoId { get; set; }
    public string Nombre { get; set; }

    public Departamento Departamento { get; set; }
}
```
En este ejemplo, la clase Departamento tiene una colección de Empleados, mientras que la clase Empleado tiene una propiedad de navegación Departamento. Esto establece una relación de uno a muchos entre las entidades.