using System;
using System.Linq.Expressions;
using _31._10._2021.Model;

namespace _31._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Math.PI);
            Console.WriteLine("Hello");
            Console.WriteLine("1-Rectangle " +
                              "2-Triangle " +
                              "3-Square" +
                              "4-Circle" +
                              "5-Hexagon ");
            int Input = Convert.ToInt32(Console.ReadLine());
            if (Input == 1)
            {
                Console.WriteLine("SDsdf");
            }
            else if(Input == 2)
            {
            
            }else if (Input == 3)
            {
                int Inputa = Convert.ToInt32(Console.ReadLine());
                int Inputb = Convert.ToInt32(Console.ReadLine());
               // Square s = new Square(Inputa, Inputb);
                Console.WriteLine(s.GetArea());
                Console.WriteLine(s.GetPerimeter());

            ;



            }
            else if(Input == 4)
            {
            
            }else if(Input == 5)
            {
            
            }

        }
         
    }
}
