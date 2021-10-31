namespace _31._10._2021.Model
{
    public class Square :Shape
    {

        public Square(double sideA)
        {
            SideA = sideA;
        }

        public override double GetArea()
        {
            return SideA*SideA;
        }

        public override double GetPerimeter()
        {
            return 4*SideA;
        }
    }
}