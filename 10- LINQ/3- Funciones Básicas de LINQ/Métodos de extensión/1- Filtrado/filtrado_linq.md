# Filtrado en LINQ

El filtrado es una operación común en la que queremos obtener un subconjunto de elementos que cumplan con ciertas condiciones. En LINQ, podemos filtrar los datos utilizando la cláusula `where` o el método de extensión `Where()`.

## Cláusula `where`

La cláusula `where` se utiliza en la sintaxis de consulta para filtrar los elementos de una colección basándose en una condición específica. Aquí tienes un ejemplo:

```csharp
var result = from element in collection
             where element.Property > 10
             select element;
```

Este código devuelve una nueva colección que contiene solo los elementos que cumplen con la condición 
`element.Property > 10`