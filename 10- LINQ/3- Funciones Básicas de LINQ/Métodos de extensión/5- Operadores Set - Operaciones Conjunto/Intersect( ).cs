/*El operador Intersect() nos permite obtener los elementos que son comunes entre dos colecciones.
 Devuelve una nueva colección que contiene solo los elementos que existen en ambas colecciones. Aquí tienes un ejemplo:*/

var set1 = new List<int> { 1, 2, 3 };
var set2 = new List<int> { 3, 4, 5 };

var intersectSet = set1.Intersect(set2);

Console.WriteLine(string.Join(", ", intersectSet)); // Resultado: 3


/*En este ejemplo, hemos declarado dos listas, set1 y set2, y utilizamos el método Intersect para obtener la intersección de ambas listas.*/