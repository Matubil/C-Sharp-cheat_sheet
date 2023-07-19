/*El método RemoveAt se utiliza para eliminar un elemento en una posición específica de una colección que implementa la interfaz IList. Aquí tienes un ejemplo de cómo usar RemoveAt:*/

var fruits = new List<string> { "Apple", "Banana", "Orange" };

fruits.RemoveAt(1);

Console.WriteLine(string.Join(", ", fruits)); // Resultado: Apple, Orange
