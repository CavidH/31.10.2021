using System;

namespace _31._10._2021.Model
{
    public class Rectangle :Shape
    {
        public double SideA;
        public double SideB;
        public override double GetArea( )
        {
            return SideA * SideB;
        }

        public override double GetPerimeter( )
        {
            return 2 * (SideA + SideB);
        }
    }
}