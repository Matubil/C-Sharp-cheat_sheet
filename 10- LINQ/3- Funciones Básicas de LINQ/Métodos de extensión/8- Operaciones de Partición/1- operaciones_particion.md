# Operaciones de Partición en LINQ

En LINQ, podemos realizar operaciones de partición para dividir una colección en subconjuntos más pequeños. Algunas de las operaciones de partición más utilizadas son:

## Operador `Take()`

El operador `Take()` nos permite tomar un número especificado de elementos desde el inicio de una colección. Aquí tienes un ejemplo:

```csharp
var result = collection.Take(count);
