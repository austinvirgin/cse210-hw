using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>(){
            new Rectangle("red", 2, 4), new Circle("blue", 4), new Square("orange", 5) 
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}