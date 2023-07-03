/*Podemos anidar múltiples operadores Select() para realizar transformaciones más complejas en nuestros datos.
 Aquí tienes un ejemplo:*/

var result = from element in collection
             select new
             {
                 Name = element.Name,
                 Category = element.Category,
                 NestedProperty = element.NestedCollection.Select(nested => nested.Property)
             };

/*Este código realiza una proyección en la colección principal y, además, realiza una proyección en la colección 
anidada NestedCollection para obtener solo la propiedad Property de cada elemento.*/