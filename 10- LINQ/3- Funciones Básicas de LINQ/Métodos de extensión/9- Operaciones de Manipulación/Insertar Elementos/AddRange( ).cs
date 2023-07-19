/*El método AddRange se utiliza para insertar múltiples elementos al final de una colección. Puedes pasar una secuencia de elementos como argumento para agregarlos todos a la colección existente. Aquí tienes un ejemplo de cómo usar AddRange:*/

var numbers = new List<int> { 1, 2, 3, 4, 5 };

var additionalNumbers = new List<int> { 6, 7, 8 };

numbers.AddRange(additionalNumbers);

Console.WriteLine(string.Join(", ", numbers)); // Resultado: 1, 2, 3, 4, 5, 6, 7, 8

/*Explicacion:
En este ejemplo, hemos declarado una lista de números y una lista adicional de números. Utilizamos el método AddRange para insertar todos los números adicionales al final de la lista existente.*/