/*El método OrderBy se utiliza para ordenar una colección en orden ascendente basándose en una clave específica. Aquí tienes un ejemplo de cómo usar OrderBy:*/

var numbers = new List<int> { 5, 3, 1, 4, 2 };

var sortedNumbers = numbers.OrderBy(x => x);

Console.WriteLine(string.Join(", ", sortedNumbers)); // Resultado: 1, 2, 3, 4, 5

/*En este ejemplo, hemos declarado una lista de números y utilizamos el método OrderBy para ordenar los números en orden ascendente.*/