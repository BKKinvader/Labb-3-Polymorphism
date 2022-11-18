using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_Polymorphism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        public override double Area()
        {
            double area = Radius * Radius * Math.PI;
            double result = Math.Round(area,2);
            return result;
        }


    }
}
