# Operadores Set en LINQ

Los operadores Set en LINQ nos permiten realizar operaciones de conjuntos, como unión, intersección y diferencia, en colecciones de elementos. Algunos de los operadores Set más comunes son:

- `Union()`: Retorna una colección que contiene los elementos distintos de dos colecciones.
- `Intersect()`: Retorna una colección que contiene los elementos comunes entre dos colecciones.
- `Except()`: Retorna una colección que contiene los elementos de una colección que no están presentes en otra colección.
- `Distinct()`: Retorna una colección que contiene los elementos distintos de una colección.

Aquí tienes algunos ejemplos de cómo utilizar estos operadores Set en LINQ:

```csharp
var union = collection1.Union(collection2);
var intersection = collection1.Intersect(collection2);
var difference = collection1.Except(collection2);
var distinct = collection.Distinct();
