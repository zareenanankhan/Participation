using System;
using System.Collections.Generic;

namespace CollectionsMaxMinAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            double examgrade;
            //collaborated with Rysa Khan
            //assumes that there are a total of five exams
            //define all variables
            List<double> exams = new List<double>();

            Console.WriteLine("How many exam grades are there?");
            int NumOfExam = Convert.ToInt32(Console.ReadLine());

            for (int i =0; i <=NumOfExam; i++)
            {
                Console.WriteLine("Enter exam grade");
                examgrade = Convert.ToDouble(Console.ReadLine());
                exams.Add(examgrade);

            }

            Console.WriteLine(exams);

            Console.ReadLine();



        }
    }
}
