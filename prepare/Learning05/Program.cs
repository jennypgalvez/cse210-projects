using System;

class Program
{
    static void Main(string[] args)
    {
        List <Shape> shapes = new List<Shape>();

        Square shape1 = new Square("Blue", 4 );
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Red", 5, 3);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Yellow", 8);
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();            
            
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}. ");
            Console.WriteLine();
        }
    
    }
}