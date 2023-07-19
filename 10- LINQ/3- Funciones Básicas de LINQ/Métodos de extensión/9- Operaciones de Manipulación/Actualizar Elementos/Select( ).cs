/*El método Select puede utilizarse para crear una nueva colección con elementos actualizados. Puedes proyectar los elementos existentes a nuevos valores y obtener una colección actualizada. Aquí tienes un ejemplo:*/

var fruits = new List<string> { "Apple", "Banana", "Orange" };

var updatedFruits = fruits.Select(fruit => fruit.ToUpper()).ToList();

Console.WriteLine(string.Join(", ", updatedFruits)); // Resultado: APPLE, BANANA, ORANGE

/*En este ejemplo, hemos utilizado el método Select para crear una nueva lista de frutas actualizada, donde cada elemento se ha convertido en mayúsculas.*/