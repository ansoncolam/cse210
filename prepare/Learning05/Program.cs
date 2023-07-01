using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square mySquare = new Square("Red",2);
        shapes.Add(mySquare);

        Rectangle myRectangle = new Rectangle("Orange",2,3);
        shapes.Add(myRectangle);

        Circle myCircle = new Circle("Yellow",4);
        shapes.Add(myCircle);

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}