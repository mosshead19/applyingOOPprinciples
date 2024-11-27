using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allOOPprinciplesApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
            new Rectangle (10,5),
            new Circle (7),
            new Triangle(10,8)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name + " Area: " + shape.CalculateArea());

            }

            Console.ReadKey();

        }
    }

    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Rectangle : Shape
    {

        private double _length;
        private double _width;
        public double Length
        {
            get => _length;
            set => _length = value >= 0 ? value : throw new ArgumentException("Length must be positive.");
        }

        public double Width
        {
            get => _width;
            set => _width = value >= 0 ? value : throw new ArgumentException("Width must be positive.");
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

    }

    class Circle : Shape
    {
        private double _radius;

       public double Radius
        {
            get => _radius;
            set => _radius = value >= 0 ? value : throw new ArgumentException("Radius must be positive.");

        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Triangle : Shape
    {
        private double _base;
        private double _height;

        public double Base
        {
            get => _base;
            private set => _base = value >= 0 ? value : throw new ArgumentException("Base cannot be negative.");
        }

        public double Height
        {
            get => _height;
            private set => _height = value >= 0 ? value : throw new ArgumentException("Height cannot be negative.");
        }

        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

    }

}
