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
            //define all variables
            List<double> exams = new List<double>();

            Console.WriteLine("How many exam grades are there?");
            int NumOfExam = Convert.ToInt32(Console.ReadLine());

            for (int i =0; i < NumOfExam; i++)
            {
                Console.WriteLine("Enter exam grade");
                examgrade = Convert.ToDouble(Console.ReadLine());
                exams.Add(examgrade);

            }
            
            Console.WriteLine("The following is your list of exam grades");
            exams.ForEach(Console.WriteLine);

            double maxvalue = exams[0];
            double minvalue = exams[0];
            double avgvalue = 0;
            double sum = 0;
            
            for (int i=0; i < exams.Count; i++)
            {
                if (maxvalue < exams[i])
                    maxvalue = exams[i];
                if (minvalue > exams[i])
                    minvalue = exams[i];
                    sum += exams[i];
            }

            avgvalue = sum / exams.Count;

            Console.WriteLine($"The highest exam grade is {maxvalue}");
            Console.WriteLine($"The lowest exam grade is {minvalue}");
            Console.WriteLine($"The average exam grade is {avgvalue}");

           
           

            Console.ReadLine();



        }
    }
}
