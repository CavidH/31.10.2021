using System;
using System.Linq.Expressions;
using System.Threading;
using _31._10._2021.Model;

namespace _31._10._2021
{
    class Program
    {
        public static int Input;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Menu();
            İnputOperation();
            Again();
        }

        private static void Again()
        {
            double Answer=PrintAndReturnInput("continue or okay \n" +
                                "1-continue \n" +
                                "2-okay");
            if (Answer==1)
            {
             Menu();   
            }
            else
            {
                Console.WriteLine("bye bye");
                Thread.Sleep(2000);
            }
            
        }

        private static void MenuCheck()
        {
            if (Input<=0 || Input >5)
            {
                Console.WriteLine("such an option does not exist");
                Menu();
            }
        }

        private static void İnputOperation()
        {
            switch (Input)
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
                default:
                    Console.WriteLine("such an option does not exist");
                    break;


            }
        }

        public static void Menu()
        {
            Console.WriteLine("Please Select number of shape \n");
            Console.WriteLine("1-Rectangle \n" +
                              "2-Triangle \n" +
                              "3-Square \n" +
                              "4-Circle \n" +
                              "5-Hexagon \n");
            string InputString = Console.ReadLine();

            try
            {
                Input = Convert.ToInt32(InputString);
            }
            catch (Exception)
            {
                Console.WriteLine("enter in the correct format");

            }
            MenuCheck();

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
