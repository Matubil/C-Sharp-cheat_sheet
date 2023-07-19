/*La función ToLookup en LINQ se utiliza para crear un ILookup<TKey, TElement>, que es una interfaz que representa una colección de claves cada una de las cuales está asociada a una o más valores. Básicamente, ToLookup nos permite agrupar elementos en una secuencia según una clave específica.*/

ILookup<TKey, TElement> ToLookup<TKey, TElement>(this IEnumerable<TElement> source, Func<TElement, TKey> keySelector);

/*source: La secuencia de elementos que se va a agrupar.
keySelector: Una función que se utiliza para obtener la clave a partir de cada elemento en la secuencia.*/

//Ejemplo de Uso

var students = new List<Student>
{
    new Student { Id = 1, Name = "Alice", Age = 20 },
    new Student { Id = 2, Name = "Bob", Age = 22 },
    new Student { Id = 3, Name = "Charlie", Age = 20 },
    new Student { Id = 4, Name = "Alice", Age = 25 }
};

var studentsByAge = students.ToLookup(student => student.Age);

foreach (var group in studentsByAge)
{
    Console.WriteLine($"Students with age '{group.Key}':");
    foreach (var student in group)
    {
        Console.WriteLine($"- {student.Name}");
    }
    Console.WriteLine();
}

#region Explicacion  Ejemplo

/*En este ejemplo, hemos creado una colección students de tipo List<Student>. Luego, utilizamos ToLookup para agrupar los estudiantes por su edad. La clave de agrupación será la edad de cada estudiante. Luego, recorremos cada grupo y mostramos los nombres de los estudiantes en cada grupo.

*/

#endregion

/*
Relación con la operación group by:
La función ToLookup es similar a la operación group by en LINQ. Ambas se utilizan para agrupar elementos en una secuencia según un criterio específico. La principal diferencia es que ToLookup devuelve un ILookup<TKey, TElement>, que es una colección que permite acceder a los grupos utilizando la clave, mientras que la operación group by devuelve una secuencia de grupos.

La ventaja de usar ToLookup es que proporciona una estructura de datos conveniente para acceder a los grupos mediante la clave, lo que facilita la manipulación de datos agrupados.
*/