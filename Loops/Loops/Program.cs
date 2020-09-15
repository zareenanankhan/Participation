using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            //Add all the values from 1 to 100 and output the sum

            int sum = 0;
            // control var condition incrementation/decrementation 
            for (int i = 1; i < 101; i++)
            {
                
                sum = sum + i; // can also be written as sum+=i

            }

            do
            {
                iterations += 1

            }



            //Console.WriteLine("The sum of 1 to 100 is " + sum);
           // Console.ReadKey();


            // ask the user if they want to perform another teratopnintil they say yes, count the number of iternations or the number of times they said yes.

            int iterations = 1; // set it to 1 becuase we know we are gonna ask them the question at least once, and then however many times from there. Not zero times.
            Console.WriteLine("Do you want to perfirm anpother iteration, yes or no?");
            string response = Console.ReadLine();



            //while (response.ToLower()== "yes")
            {
                //iterations += 1;
                //Console.WriteLine("Do you want to perfirm anpother iteration, yes or no?");
                //response = Console.ReadLine();

            }

           // Console.WriteLine("The number orf times the user said yes or the number of iterations were" + iterations);
           // Console.ReadKey(); //waitign for the user to press a key to exit

        }
    }
}
