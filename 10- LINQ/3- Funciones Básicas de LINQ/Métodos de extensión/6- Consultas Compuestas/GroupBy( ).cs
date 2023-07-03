/*El operador GroupBy() nos permite agrupar elementos de una colección basándose en una clave común.
 Aquí tienes un ejemplo:*/

var result = from element in collection
             group element by element.Category into grouped
             select new { Category = grouped.Key, Count = grouped.Count() };

/*Este código agrupa los elementos de la colección según su propiedad Category y cuenta el número de
 elementos en cada grupo.*/