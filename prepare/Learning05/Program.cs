using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("Yellow", 2);
        System.Console.WriteLine($"the square is {sq.GetColor()}");
        System.Console.WriteLine($"The area is {sq.GetArea()}");

        Rectangle rect = new Rectangle("Orange", 3 , 4);
        System.Console.WriteLine($"the rectangle is {rect.GetColor()}");
        System.Console.WriteLine($"The area is {rect.GetArea()}");

        Circle cir = new Circle("Red", 7);
        System.Console.WriteLine($"the Circle is {cir.GetColor()}");
        System.Console.WriteLine($"The area is {cir.GetArea()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(sq);
        shapes.Add(rect);
        shapes.Add(cir);

        foreach (Shape shape in shapes)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"The color of the shape is {shape.GetColor()}");
            System.Console.WriteLine($"The area of the shape is {shape.GetArea()}");
        }
    }
}