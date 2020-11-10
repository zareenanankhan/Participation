using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.Radius = 7.5;
            Console.WriteLine($"The area of a circle with {myCircle.Radius} is {myCircle.CalculateArea()}\n" +
                              $"   and a perimeter of {myCircle.CalculatePerimeter()}");

            Circle circle2 = new Circle();
            circle2.Radius = 8282828282;
            double areaOfCircle2 = circle2.CalculateArea();
            double perimeterOfCircle2 = circle2.CalculatePerimeter();

            Circle circle3 = new Circle(3.5);

            Rectangle myRectangle = new Rectangle();
            myRectangle.length = 2;
            myRectangle.width = 2;
            Console.WriteLine($"The area of the rectangle with {myRectangle.length} and {myRectangle.width} is {myRectangle.CalculateAreaRect()}\n" +
                $"and the perimeter is {myRectangle.CalculatePerimeterRect()}");

            Rectangle rectangle2 = new Rectangle();
            rectangle2.length = 2;
            rectangle2.width = 2;
            double areaofrect2 = rectangle2.CalculateAreaRect();
            double perimeterofrect2 = rectangle2.CalculatePerimeterRect();

            Rectangle rect3 = new Rectangle(4);


            Console.ReadKey();
        }
    }
}
