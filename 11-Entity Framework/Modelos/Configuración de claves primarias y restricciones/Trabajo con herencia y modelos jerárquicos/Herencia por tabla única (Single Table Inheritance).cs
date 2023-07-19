/*En la herencia por tabla única, todas las clases derivadas comparten la misma tabla en la base de datos. Se utiliza una columna adicional para identificar el tipo de entidad.

Aquí tienes un ejemplo de cómo se podría definir una herencia por tabla única en Entity Framework:*/
public class Animal
{
    public int AnimalId { get; set; }
    public string Name { get; set; }
}

public class Dog : Animal
{
    public string Breed { get; set; }
}

public class Cat : Animal
{
    public string FurColor { get; set; }
}

/*En este ejemplo, la clase Animal es la clase base, y las clases Dog y Cat son clases derivadas que heredan de la clase base. Entity Framework generará una única tabla llamada "Animals" en la base de datos, que contendrá todas las propiedades de las clases base y derivadas.*/