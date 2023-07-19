/*
# Operación de búsqueda: `Contains`

La operación `Contains` en LINQ se utiliza para verificar si una secuencia contiene un elemento específico. Devuelve un valor booleano que indica si el elemento se encuentra en la secuencia o no. Aquí tienes la sintaxis básica de `Contains`:

*/
var result = collection.Contains(value);

/*collection: La colección en la que deseas realizar la verificación.
value: El valor que deseas buscar en la colección.*/

//Ejemplo

var numbers = new List<int> { 1, 2, 3, 4, 5 };

var result = numbers.Contains(3);

Console.WriteLine(result);

#region 

/*En este ejemplo, verificamos si la colección numbers contiene el valor 3. El resultado será true, ya que 3 se encuentra en la colección.*/

#endregion