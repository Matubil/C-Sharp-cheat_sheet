int[] numeros = { 1, 2, 3, 4, 5 };

var numerosPares = numeros.Where(num => num % 2 == 0);

foreach (var num in numerosPares)
{
    Console.WriteLine(num);
}
