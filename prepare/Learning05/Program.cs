using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red");
        square.SetColor("Blue");
        Console.WriteLine("Square: ");
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Area: {square.GetArea()}\n");

        Rectangle rectangle = new Rectangle("red");
        rectangle.SetColor("Green");
        Console.WriteLine("Rectangle: ");
        Console.WriteLine($"Color: {rectangle.GetColor()}");
        Console.WriteLine($"Area: {rectangle.GetArea()}\n");

        Circle circle = new Circle("red");
        circle.SetColor("Yellow");
        Console.WriteLine("Circle: ");
        Console.WriteLine($"Color: {circle.GetColor()}");
        Console.WriteLine($"Area: {circle.GetArea()}\n");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape + ":");
            Console.WriteLine($"Color: {shape.GetColor()} but from a list");
            Console.WriteLine($"Area: {shape.GetArea()} but from a list\n");
        }
    }
}