using System;
using System.Linq.Expressions;
using _31._10._2021.Model;

namespace _31._10._2021
{
    class Program
    {
        public static int input;

        static void Main(string[] args)
        {

            menu();


            switch (input)
            {
                case 1:
                    double InputRecA = PrintAndReturnInput("please insert side a");
                    double InputRecB = PrintAndReturnInput("please insert side b");
                    Rectangle rectangle = new Rectangle(InputRecA, InputRecB);
                    Console.WriteLine("area:" + rectangle.GetArea());
                    Console.WriteLine("perimeter:" + rectangle.GetPerimeter());

                    break;
                case 2:
                    double InputTriA = PrintAndReturnInput("please insert side a");
                    double InputTriB = PrintAndReturnInput("please insert side b");
                    double InputTriC = PrintAndReturnInput("please insert side c");
                    Triangle triangle = new Triangle(InputTriA, InputTriB, InputTriC);
                    Console.WriteLine("area:" + triangle.GetArea());
                    Console.WriteLine("perimeter:" + triangle.GetPerimeter());
                    break;
                case 3:
                    double InputSquA = PrintAndReturnInput("please insert side a");
                    Square square = new Square(InputSquA);
                    Console.WriteLine("area:" + square.GetArea());
                    Console.WriteLine("perimeter:" + square.GetPerimeter());
                    break;
                case 4:
                    double InputRadius = PrintAndReturnInput("please insert radius");
                    Circle circle = new Circle(InputRadius);
                    Console.WriteLine("area:" + circle.GetArea());
                    Console.WriteLine("perimeter:" + circle.GetPerimeter());
                    break;
                case 5:
                    double InputHexA = PrintAndReturnInput("please insert Side a");
                    Hexagon hexagon = new Hexagon(InputHexA);
                    Console.WriteLine("area:" + hexagon.GetArea());
                    Console.WriteLine("perimeter:" + hexagon.GetPerimeter());
                    break;


            }

        }

        public static void menu()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please Select number ");
            Console.WriteLine("1-Rectangle " +
                              "2-Triangle " +
                              "3-Square" +
                              "4-Circle" +
                              "5-Hexagon ");
            string InputString = Console.ReadLine();

            try
            {
                input = Convert.ToInt32(InputString);
            }
            catch (Exception)
            {
                Console.WriteLine("Duzgun formatda daxil edin");
                throw;
            }

        }

        public static double PrintAndReturnInput(String Message)
        {
            double Side = 0;
            Console.WriteLine(Message);
            try
            {
                Side = Convert.ToDouble(Console.ReadLine());

            }
            catch (Exception e)
            {
                Console.WriteLine("duzgun formatda daxil edin");
            }

            return Side;
        }

    }
}
