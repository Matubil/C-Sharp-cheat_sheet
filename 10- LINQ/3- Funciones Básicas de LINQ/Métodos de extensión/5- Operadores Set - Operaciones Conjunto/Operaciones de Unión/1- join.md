# Operación de unión: `Join`

La operación `Join` en LINQ permite combinar elementos de dos colecciones diferentes en base a una clave común. Se utiliza para crear relaciones entre dos conjuntos de datos relacionados. Aquí tienes la sintaxis básica de `Join`:

```csharp
var result = collection1.Join(
    collection2,
    outerKeySelector,
    innerKeySelector,
    resultSelector
);
```

`collection1`: La primera colección que deseas unir.
`collection2`: La segunda colección que deseas unir.
`outerKeySelector`: Una función que selecciona la clave en la primera colección.
`innerKeySelector`: Una función que selecciona la clave en la segunda colección.
`resultSelector`: Una función que especifica cómo se creará cada elemento del resultado.