//Supongamos que tenemos una lista de objetos `Person` con propiedades como `Name`, `Age` y `City`. Podemos realizar una consulta para obtener todas las personas mayores de 18 años y ordenarlas por nombre de la siguiente manera:

var adults = from person in people
             where person.Age > 18
             orderby person.Name
             select person;
