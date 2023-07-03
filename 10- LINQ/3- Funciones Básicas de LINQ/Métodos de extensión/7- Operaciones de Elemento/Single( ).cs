/*El operador Single() nos permite obtener el único elemento de una colección que cumple con una condición
 determinada. Si no se encuentra ningún elemento o se encuentran múltiples elementos que cumplen la condición,
  se lanza una excepción. Aquí tienes un ejemplo:*/

var result = collection.Single(element => element.Property == value);

/*Este código busca el único elemento de la colección que tenga la propiedad Property igual al valor value.*/