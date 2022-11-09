using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            double area = Length * Width;
            double result = Math.Round(area, 2);
            return result;
        }

    }
}
