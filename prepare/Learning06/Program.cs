using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5);
        Rectangle rectangle = new Rectangle("green", 5, 6);        
        Circle circle = new Circle("red", 5);
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
            Console.WriteLine();
        }
    }
}