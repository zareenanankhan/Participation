using System;
using System.IO;

namespace ProcessingCSV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"SalesJan2009.csv";

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');

                string transactiondate = pieces[0];
                string paymenttype = pieces[3];
                string name = pieces[4];
                string country = pieces[7];

                if (paymenttype == "Visa" && country == "United States")
                {
                    Console.WriteLine($"All individuals who have paid using Visa card and live in the US are {name}");
                    Console.WriteLine($"All transaction date with Visa card payments in the {transactiondate}");
                }

            }
            Console.ReadLine();
        }
    }
}
