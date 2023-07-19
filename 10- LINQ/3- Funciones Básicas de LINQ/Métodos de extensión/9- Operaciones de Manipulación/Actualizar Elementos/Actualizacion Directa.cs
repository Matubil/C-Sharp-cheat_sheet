/*Puedes actualizar directamente los elementos de una colección utilizando la sintaxis de asignación. Aquí tienes un ejemplo de cómo actualizar un elemento en una lista:*/

var fruits = new List<string> { "Apple", "Banana", "Orange" };

fruits[1] = "Mango";

Console.WriteLine(string.Join(", ", fruits)); // Resultado: Apple, Mango, Orange

/*En este ejemplo, hemos declarado una lista de frutas y hemos actualizado el elemento en la posición 1 asignándole el valor "Mango".*/