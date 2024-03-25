using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        Square sqr = new Square();
        Circle circle = new Circle();

        sqr.SetColor("red");
        circle.SetColor("blue");
        rect.SetColor("orange");

        sqr.SetSide(12);
        rect.SetLenght(8);
        rect.SetWidth(5);
        circle.SetRadius(5.5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(sqr);
        shapes.Add(rect);

        foreach(Shape shape in shapes){
            Console.WriteLine($"Shape color: {shape.GetColor()} area: {shape.GetArea()}");
        }
    }
}