/*LINQ permite realizar consultas sobre colecciones de datos, como arreglos (arrays) o listas, de una manera más legible
y expresiva. Puedes utilizar LINQ para filtrar, ordenar, agrupar y proyectar datos de manera sencilla y eficiente*/

int[] numeros = { 1, 2, 3, 4, 5 };

var numerosPares = from num in numeros
                   where num % 2 == 0
                   select num;

foreach (var num in numerosPares)
{
    Console.WriteLine(num);
}
