// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        // Create instances of each shape and add to the list
        shapes.Add(new Square("Red", 5f));
        shapes.Add(new Rectangle("Blue", 4f, 6f));
        shapes.Add(new Circle("Green", 3f));

        // Iterate through the list of shapes and display their color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}
