# Operación de unión: `Zip`

La operación `Zip` en LINQ combina dos colecciones en una nueva colección mediante la aplicación de una función de combinación a los elementos correspondientes de ambas colecciones. Esta operación se utiliza cuando queremos combinar elementos uno a uno de dos colecciones en un solo resultado. Aquí tienes la sintaxis básica de `Zip`:

```csharp
var result = collection1.Zip(
    collection2,
    resultSelector
);

```

`collection1`: La primera colección que deseas combinar.
`collection2`: La segunda colección que deseas combinar.
`resultSelector`: Una función que especifica cómo se combinarán los elementos correspondientes de ambas colecciones.