using System;
using System.Drawing;

namespace Labb_3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle()
            {
                Length = 3,
                Width = 2
            };
            Console.WriteLine("Area of the Rectangle is " + R1.Area() + "cm²");


            Square S1 = new Square()
            {
              Length = 25

            };
            Console.WriteLine("Area of the Square is " + S1.Area() + "cm²");

            Circle C1 = new Circle()
            {
                Radius = 3,
      
            };
            Console.WriteLine("Area of the Circle is " + C1.Area() + "cm²");
        }
    }
}
