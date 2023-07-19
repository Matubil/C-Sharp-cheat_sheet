/*
# Operación de búsqueda: `All`

La operación `All` en LINQ se utiliza para verificar si todos los elementos en una secuencia cumplen con una condición especificada. Devuelve un valor booleano que indica si todos los elementos cumplen con la condición o no. Aquí tienes la sintaxis básica de `All`:

*/
var result = collection.All(predicate);

/*collection: La colección en la que deseas realizar la verificación.
predicate: Una condición que se utiliza para verificar cada elemento de la colección.*/

//Ejemplo

var numbers = new List<int> { 1, 2, 3, 4, 5 };

var result = numbers.All(x => x > 0);

Console.WriteLine(result);


#region Explicacion Ejemplo

/*En este ejemplo, verificamos si todos los elementos en la colección numbers son mayores que 0. El resultado será true, ya que todos los elementos cumplen con la condición.*/

#endregion