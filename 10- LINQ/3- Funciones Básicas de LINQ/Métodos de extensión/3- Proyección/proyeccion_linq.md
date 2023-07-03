# Proyección en LINQ

La proyección es una operación en la que queremos obtener solo las propiedades o partes específicas de los elementos de una colección. En LINQ, podemos realizar la proyección utilizando la cláusula `select` o el método de extensión `Select()`.

## Cláusula `select`

La cláusula `select` se utiliza en la sintaxis de consulta para especificar las propiedades o partes que queremos obtener de cada elemento. Aquí tienes un ejemplo:

```csharp
var result = from element in collection
             select element.Property;

/*Este código devuelve una nueva colección que contiene solo las propiedades element.Property de cada elemento de la colección.*/