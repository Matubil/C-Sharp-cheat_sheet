/*El método ForEach permite recorrer una colección y aplicar una acción a cada elemento. Puedes utilizar este método para actualizar los elementos según tus necesidades. Aquí tienes un ejemplo:*/

var fruits = new List<string> { "Apple", "Banana", "Orange" };

fruits.ForEach((fruit, index) =>
{
    fruits[index] = fruit.ToUpper();
});

Console.WriteLine(string.Join(", ", fruits)); // Resultado: APPLE, BANANA, ORANGE

/*Explicacion:
En este ejemplo, hemos utilizado el método ForEach para recorrer la lista de frutas y actualizar cada elemento convirtiéndolo en mayúsculas.
*/