
/*El operador `SelectMany()` nos permite realizar una proyección y aplanamiento en una sola operación. Este operador es útil cuando trabajamos con colecciones anidadas. Aquí tienes un ejemplo:*/

var result = collection.SelectMany(element => element.NestedCollection);


/*Este código realiza una proyección de la colección anidada `NestedCollection` de cada elemento de la colección principal.*/