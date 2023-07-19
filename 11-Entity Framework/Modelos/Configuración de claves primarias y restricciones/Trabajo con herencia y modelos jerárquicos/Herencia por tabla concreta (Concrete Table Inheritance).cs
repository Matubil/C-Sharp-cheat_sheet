/*En la herencia por tabla concreta, cada clase derivada tiene su propia tabla en la base de datos. No se utiliza una tabla para la clase base.

Aquí tienes un ejemplo de cómo se podría definir una herencia por tabla concreta en Entity Framework:*/

public abstract class Shape
{
    public int ShapeId { get; set; }
    public string Color { get; set; }
}

public class Circle : Shape
{
    public double Radius { get; set; }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
}

/*En este ejemplo, la clase abstracta Shape es la clase base, y las clases Circle y Rectangle son clases derivadas que heredan de la clase base. Entity Framework generará una tabla separada para cada clase derivada, que contendrá solo las propiedades específicas de cada clase.*/