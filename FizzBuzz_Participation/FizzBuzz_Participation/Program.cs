using System;

namespace FizzBuzz_Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            //if the number has a remainder = number % 3; aka remainder of 3
            //bool hasRemainder = remainder == 0;

            //BOOLEAN OPERATORS:
            //      OR  = ||
            //      AND = &&
            
            if ((number % 3 == 0) && (number % 5 == 0))
                
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)

            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)

            {
                Console.WriteLine("Buzz");
            }
            else Console.WriteLine(number);

            Console.ReadLine();
            
        }
    }
}
