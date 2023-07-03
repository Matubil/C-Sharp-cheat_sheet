# Ordenamiento en LINQ

El ordenamiento es una operación común en la que queremos ordenar los elementos de una colección en base a ciertos criterios. En LINQ, podemos realizar el ordenamiento utilizando la cláusula `orderby` o los métodos de extensión `OrderBy()` y `OrderByDescending()`.

## Cláusula `orderby`

La cláusula `orderby` se utiliza en la sintaxis de consulta para especificar los criterios de ordenamiento. Aquí tienes un ejemplo:

```csharp
var result = from element in collection
             orderby element.Property ascending
             select element;

Este código devuelve una nueva colección que contiene los elementos ordenados de forma ascendente según la propiedad element.Property.