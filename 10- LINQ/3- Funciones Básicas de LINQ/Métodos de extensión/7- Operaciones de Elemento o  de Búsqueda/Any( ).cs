/*# Operación de búsqueda: `Any`

La operación `Any` en LINQ se utiliza para verificar si al menos un elemento en una secuencia cumple con una condición especificada. Devuelve un valor booleano que indica si se encontró al menos un elemento que cumple con la condición o no. Aquí tienes la sintaxis básica de `Any`:
*/

var result = collection.Any(predicate);

/*collection: La colección en la que deseas realizar la verificación.
predicate: Una condición que se utiliza para verificar cada elemento de la colección.*/

//Ejemplo

var numbers = new List<int> { 1, 2, 3, 4, 5 };

var result = numbers.Any(x => x > 3);

Console.WriteLine(result);

#region Explicacion

/*En este ejemplo, verificamos si hay al menos un elemento en la colección numbers que sea mayor que 3. El resultado será true, ya que hay elementos en la colección que cumplen con la condición.*/

#endregion