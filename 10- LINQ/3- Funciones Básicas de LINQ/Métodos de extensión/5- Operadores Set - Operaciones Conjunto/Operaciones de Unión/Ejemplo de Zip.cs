var numbers1 = new List<int> { 1, 2, 3 };
var numbers2 = new List<int> { 10, 20, 30 };

var result = numbers1.Zip(
    numbers2,
    (n1, n2) => n1 + n2
);

foreach (var item in result)
{
    Console.WriteLine(item);
}

#region 

/*En este ejemplo, combinamos las colecciones numbers1 y numbers2 sumando los elementos correspondientes uno a uno. El resultado es una nueva colección con los valores { 11, 22, 33 }.*/

#endregion