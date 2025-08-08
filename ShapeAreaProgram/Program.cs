using System;

namespace ShapeAreaProgram
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
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

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main()
        {
            Shape circle = new Circle(9);
            Console.WriteLine($"Area of Circle: {circle.GetArea():F2}cm²");

            Shape rectangle = new Rectangle(8, 12);
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea():F2}cm²");
        }
    }
}
