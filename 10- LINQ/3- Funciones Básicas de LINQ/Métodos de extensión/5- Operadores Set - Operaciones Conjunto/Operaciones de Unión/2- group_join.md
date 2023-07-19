# Operación de unión: `GroupJoin`

La operación `GroupJoin` en LINQ permite combinar elementos de dos colecciones diferentes en base a una clave común y agrupar los resultados en una estructura jerárquica. Se utiliza cuando queremos obtener elementos de la colección de origen junto con sus elementos relacionados de la segunda colección en forma de grupos. Aquí tienes la sintaxis básica de `GroupJoin`:

```csharp
var result = collection1.GroupJoin(
    collection2,
    outerKeySelector,
    innerKeySelector,
    resultSelector
);

```

`collection1`: La primera colección que deseas unir y agrupar.
`collection2`: La segunda colección que deseas unir.
`outerKeySelector`: Una función que selecciona la clave en la primera colección.
`innerKeySelector`: Una función que selecciona la clave en la segunda colección.
`resultSelector`: Una función que especifica cómo se creará cada grupo en el resultado.