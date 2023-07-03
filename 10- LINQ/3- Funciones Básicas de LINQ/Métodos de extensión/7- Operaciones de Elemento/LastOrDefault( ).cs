/*El operador LastOrDefault() nos permite obtener el último elemento de una colección que cumple con una 
condición determinada. Si no se encuentra ningún elemento que cumpla la condición, se devuelve el valor 
predeterminado del tipo de elemento. Aquí tienes un ejemplo:*/

var result = collection.LastOrDefault(element => element.Property == value);

/* Este código busca el último elemento de la colección que tenga la propiedad Property igual al valor value.*/