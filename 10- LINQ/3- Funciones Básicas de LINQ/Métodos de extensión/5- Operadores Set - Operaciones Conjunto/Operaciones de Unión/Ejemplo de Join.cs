var customers = new List<Customer>
{
    new Customer { Id = 1, Name = "John" },
    new Customer { Id = 2, Name = "Jane" },
    new Customer { Id = 3, Name = "Bob" }
};

var orders = new List<Order>
{
    new Order { OrderId = 1, CustomerId = 2, TotalAmount = 100 },
    new Order { OrderId = 2, CustomerId = 1, TotalAmount = 200 },
    new Order { OrderId = 3, CustomerId = 2, TotalAmount = 150 }
};

var result = customers.Join(
    orders,
    customer => customer.Id,
    order => order.CustomerId,
    (customer, order) => new
    {
        customer.Name,
        order.OrderId,
        order.TotalAmount
    }
);

foreach (var item in result)
{
    Console.WriteLine($"Customer: {item.Name}, OrderId: {item.OrderId}, TotalAmount: {item.TotalAmount}");
}


#region Explicacion

/*En este ejemplo, unimos las colecciones customers y orders en base al campo Id de customers y el campo CustomerId de orders. Utilizamos una función de selección de resultados para crear un objeto anónimo con el nombre del cliente, el ID del pedido y el monto total.*/

#endregion