/*El método Insert se utiliza para insertar un elemento en una posición específica dentro de una colección que implementa la interfaz IList. Aquí tienes un ejemplo de cómo usar Insert:*/

var fruits = new List<string> { "Apple", "Banana", "Orange" };

fruits.Insert(1, "Mango");

Console.WriteLine(string.Join(", ", fruits)); // Resultado: Apple, Mango, Banana, Orange

/*Explicacion
En este ejemplo, hemos declarado una lista de frutas y utilizamos el método Insert para insertar la fruta "Mango" en la posición 1 de la lista.*/