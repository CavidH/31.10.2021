using System;

namespace _31._10._2021.Model
{
    public class Circle :Shape
    {
        private double Radius;
        public double Pi = 3.14;

        public Circle(double radius)
        {
            Radius = radius;
        }
       

        public override double GetArea( )
        {
            return Pi * Radius * Radius;
        }

        public override double GetPerimeter( )
        {
            return 2 * Pi * Radius;
        }
        
    }
}