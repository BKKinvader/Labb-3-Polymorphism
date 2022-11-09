using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_Polymorphism
{
    internal class Square : Geometry
    {
        public double Length { get; set; }
        

        public override double Area()
        {
            double area = Length * Length;
            double result = Math.Round(area, 2);
            return result;
        }


    }
}
