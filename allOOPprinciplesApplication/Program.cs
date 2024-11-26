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

        }
    }

    class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    class Rectangle : Shape
    {

        private double _length;
        private double _width;
        public double Length
        {
            get => _length;
            set
            {
                if (value >= 0)
                    _length = value;
                else
                    throw new ArgumentException("Length must be positive");
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                if (value >= 0)
                    _width = value;
                else
                    throw new ArgumentException("Width must be positive");
            }
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
            set
            {
                if (value >= 0)
                    _radius = value;
                else
                    throw new ArgumentException("Radius must be positive");
            }
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

    class Triangle : Rectangle
    {

        public Triangle(double Length, double width)
           : base(Length, width)
        { }

        public override double CalculateArea()
        {
            return 0.5 * Length * Width;
        }

    }

}
