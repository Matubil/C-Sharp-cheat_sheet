/*El método Remove se utiliza para eliminar la primera aparición de un elemento específico de una colección que implementa la interfaz IList. Aquí tienes un ejemplo de cómo usar Remove:*/

var fruits = new List<string> { "Apple", "Banana", "Orange" };

fruits.Remove("Banana");

Console.WriteLine(string.Join(", ", fruits)); // Resultado: Apple, Orange

/*En este ejemplo, hemos declarado una lista de frutas y utilizamos el método Remove para eliminar la fruta "Banana" de la lista.*/