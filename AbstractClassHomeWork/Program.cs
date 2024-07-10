using System;
abstract class Shape
{
    public abstract void Area();
    public abstract void Perimeter();
    public abstract override string ToString();
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override void Area()=>Console.WriteLine("Area of Rectangle: " + (Width * Height));
    public override void Perimeter()=>Console.WriteLine("Perimeter of Rectangle: " + 2 * (Width + Height));
    public override string ToString()=>$"Rectangle: Width = {Width}, Height = {Height},";
}

class Square : Shape
{
    public double Teref { get; set; }

    public Square(double teref)
    {
        Teref = teref;
    }

    public override void Area()=>Console.WriteLine("Area of Square: " + (Teref * Teref));
    public override void Perimeter()=>Console.WriteLine("Perimeter of Square: " + 4 * Teref);
    public override string ToString()=> $"Square: Teref = {Teref}";
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override void Area()=>Console.WriteLine("Area of Circle: " + (3.14 * Radius * Radius));
    public override void Perimeter()=>Console.WriteLine("Perimeter of Circle: " + (2 * 3.14 * Radius));
    public override string ToString()=> $"Circle: Radius = {Radius}";
}

class Program
{
    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle(4, 5);
        rectangle.Area();
        rectangle.Perimeter();
        Console.WriteLine(rectangle.ToString());

        Shape square = new Square(4);
        square.Area();
        square.Perimeter();
        Console.WriteLine(square.ToString());

        Shape circle = new Circle(3);
        circle.Area();
        circle.Perimeter();
        Console.WriteLine(circle.ToString());
    }
}
