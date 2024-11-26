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
            Rectangle rectangle = new Rectangle { Length = 10, Width = 5 };
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());

            Circle circle = new Circle { Radius = 7 };
            Console.WriteLine("Circle Area: " + circle.CalculateArea());

        }
    }

    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }

    class Circle
    {
        public double Radius { get; set; }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    /*Additional Requirement:
 •	Refactor the Main method to use polymorphism, making it adaptable for new shapes.
 •	Add a Triangle to the system.

 class Program
 {
     static void Main()
     {
         // Using polymorphism
         Shape[] shapes = new Shape[]
         {
             new Rectangle { Length = 10, Width = 5 },
             new Circle { Radius = 7 }
         };

         foreach (var shape in shapes)
         {
             Console.WriteLine("Area: " + shape.CalculateArea());
         }
     }
 }
 */

}
