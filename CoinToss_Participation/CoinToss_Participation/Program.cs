using System;

namespace CoinToss_Participation
{
    class Program
    {

        const string DEVELOPER = "Zareen Anan Khan";
        const int HEADS = 1;
        const int TAILS = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Pick 'HEADS' or 'TAILS.'");
            string input = Console.ReadLine();

            Random rnd = new Random();
            int number = rnd.Next(1, 2);

            if ((number == HEADS) && (input.ToUpper() == "HEADS"))

            {
                Console.WriteLine("The coin landed on 'heads,' your guess was right.");
            }

            else if ((number == TAILS) && (input.ToUpper() == "TAILS"))

            {
                Console.WriteLine("The coin landed on 'tails,' your guess was correct.");
            }

            else

            {
                Console.WriteLine("Sorry, your answer was incorrect.");
            }

            Console.WriteLine(DEVELOPER);


        }
    }
}
