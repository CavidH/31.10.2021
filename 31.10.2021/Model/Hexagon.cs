using System;

namespace _31._10._2021.Model
{
    public class Hexagon :Shape
    {

        public Hexagon(double sideA)
        {
            SideA = sideA;
        }
       

        public override double GetArea()
        {
            return (3 * Math.Sqrt(3)) / 2 * SideA * SideA;
        }

        public override double GetPerimeter()
        {
            return 6 * SideA;
        }
    }
}