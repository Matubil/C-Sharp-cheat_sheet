/*El método RemoveAll se utiliza para eliminar todos los elementos que cumplan con una condición específica de una colección. Aquí tienes un ejemplo de cómo usar RemoveAll:*/

var numbers = new List<int> { 1, 2, 3, 4, 5 };

numbers.RemoveAll(x => x % 2 == 0);

Console.WriteLine(string.Join(", ", numbers)); // Resultado: 1, 3, 5

/*En este ejemplo, hemos declarado una lista de números y utilizamos el método RemoveAll para eliminar todos los números pares de la lista.*/