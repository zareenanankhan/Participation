using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Loops__Guess_a_number
{
    class Program
    {
      

        static void Main(string[] args)
        {
            // define variables
            int value1;
            int value2;
            int number;
            int guessnumber;
    
            // ask for range

            Console.WriteLine("Please insert mimumum of range to be used in this exercise.");
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert maxumum of range to be used in this exercise.");
            value2 = Convert.ToInt32(Console.ReadLine());

            // generate random variables between range

            Random rnd = new Random();
            number = rnd.Next(value1, (value2+1));
            Console.WriteLine(number);


            // do while loop becuase we want at least one resule, and because we want an indefinite loop since we do not know how many tries they will need to guess right.
            do
            {
                Console.WriteLine("Please guess a number between your provided range.");
                guessnumber = Convert.ToInt32(Console.ReadLine());


            } while (number != guessnumber);

            // Once out of the loop, no lese statement required because it assumes the only way it is out of the loop here is because they guessed correctly.
            Console.WriteLine("You guessed correctly!");

            Console.ReadKey();
        }
    }
}
