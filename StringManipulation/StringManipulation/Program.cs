using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string instanceOfString;
            string whattochange;
            string changeto;
            string newstring;

            instanceOfString="Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(instanceOfString);

            Console.WriteLine("What is the word you wnat to look for in the above sentence?");
            whattochange=Console.ReadLine();

            Console.WriteLine("What is the word you would like to change it to?");
            changeto=Console.ReadLine();

            
            bool contains = instanceOfString.Contains(whattochange);

            if (contains)
            {
                instanceOfString = instanceOfString.Replace(whattochange, changeto);
                Console.WriteLine(instanceOfString);

            }
            else
            {
                Console.WriteLine("Sorry, I could not find your " + changeto);
                for (int i = changeto.Length - 1; i >= 0; i--) //x is the length of the string
                {

                    string changeto2 = changeto[i].ToString();
                    Console.Write(changeto2);

                }
                Console.ReadKey();

            }
           




        }
    }
}
