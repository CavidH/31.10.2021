using System;

namespace _31._10._2021.Model
{
    public class Triangle: Shape
    {
        public double SideA;
        public double SideB;
        public double SideC;
        public double Heron;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetArea( )
        {
            Heron = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(Heron * (Heron - SideA) * (Heron - SideB) * (Heron - SideC));

        }

        public override double GetPerimeter( )
        {
            return SideA + SideB + SideC;
        }
    }
}