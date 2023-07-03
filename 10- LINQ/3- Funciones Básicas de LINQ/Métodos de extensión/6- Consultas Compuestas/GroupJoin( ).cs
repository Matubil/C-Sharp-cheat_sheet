/* El operador GroupJoin() nos permite combinar dos colecciones basándose en una clave común y agrupar los resultados.
 Aquí tienes un ejemplo:*/

var result = from element1 in collection1
             join element2 in collection2
             on element1.Key equals element2.Key into grouped
             select new { element1, Group = grouped };


/*Este código realiza una combinación de las colecciones collection1 y collection2 en base a la clave Key de cada elemento
 y agrupa los resultados en la propiedad Group.*/