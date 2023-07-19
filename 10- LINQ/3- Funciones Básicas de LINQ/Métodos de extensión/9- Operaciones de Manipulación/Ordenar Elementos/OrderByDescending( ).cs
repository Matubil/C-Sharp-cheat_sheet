/*El método OrderByDescending se utiliza para ordenar una colección en orden descendente basándose en una clave específica. Aquí tienes un ejemplo de cómo usar OrderByDescending:*/

var numbers = new List<int> { 5, 3, 1, 4, 2 };

var sortedNumbers = numbers.OrderByDescending(x => x);

Console.WriteLine(string.Join(", ", sortedNumbers)); // Resultado: 5, 4, 3, 2, 1

/*En este ejemplo, hemos declarado una lista de números y utilizamos el método OrderByDescending para ordenar los números en orden descendente.*/