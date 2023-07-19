/*Cuando necesites realizar una ordenación secundaria basada en otra clave después de una ordenación primaria, puedes usar los métodos ThenBy y ThenByDescending. Aquí tienes un ejemplo:*/
var products = new List<Product>
{
    new Product { Id = 1, Name = "Apple", Category = "Fruit", Price = 2.5 },
    new Product { Id = 2, Name = "Banana", Category = "Fruit", Price = 1.5 },
    new Product { Id = 3, Name = "Carrot", Category = "Vegetable", Price = 3.0 },
    new Product { Id = 4, Name = "Orange", Category = "Fruit", Price = 2.0 }
};

var sortedProducts = products.OrderBy(p => p.Category).ThenByDescending(p => p.Price);

foreach (var product in sortedProducts)
{
    Console.WriteLine($"Product: {product.Name}, Category: {product.Category}, Price: {product.Price}");
}

/*En este ejemplo, hemos declarado una lista de productos y utilizamos OrderBy para ordenar los productos por categoría y luego utilizamos ThenByDescending para realizar una ordenación secundaria por precio en orden descendente.*/