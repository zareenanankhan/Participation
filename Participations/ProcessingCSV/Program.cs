using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace ProcessingCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filepath = @"‪C:\Users\nazar\Downloads\sales_data_sample.csv";
            string filepath = @"sales_data_sample.csv";

            string[] lines = File.ReadAllLines(filepath);

            double sum = 0;
            double sumfor2003 = 0;
            double sumfor2004 = 0;
            double sumfor2005 = 0;
            double sumforJan = 0;
            double sumforFeb = 0;
            double sumforMarch= 0;
            double sumforApril = 0;
            double sumforMay = 0;
            double sumforJune = 0;
            double sumforJuly = 0;
            double sumforAug = 0;
            double sumforSept = 0;
            double sumforOct = 0;
            double sumforNov = 0;
            double sumforDec = 0;


            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces= line.Split(',');
                double sale = Convert.ToDouble(pieces[4]);
                string year = pieces[9];
                string month = pieces[8];

                //sum=sum+Convert.ToDouble(pieces[4])
                if (pieces[6].Trim().ToLower() == "shipped")
                { 
                    if (year == "2003")
                    {
                        sumfor2003 += sale;
                    }
                    else if (year == "2004")
                    {
                        sumfor2004 += sale;
                    }
                    else
                    {
                        sumfor2005 += sale;
                    }
                    sum += sale;

                    if (month == "1")
                    {
                        sumforJan += sale;
                    }
                    else if (month == "2")
                    {
                        sumforFeb += sale; 
                    }
                    else if (month == "3")
                    {
                        sumforMarch += sale;
                    }
                    else if (month == "4")
                    {
                        sumforApril += sale;
                    }
                    else if (month == "5")
                    {
                        sumforMay += sale;
                    }
                    else if (month == "6")
                    {
                        sumforJune += sale;
                    }
                    else if (month == "7")
                    {
                        sumforJuly += sale;
                    }
                    else if (month == "8")
                    {
                        sumforAug += sale;
                    }
                    else if (month == "9")
                    {
                        sumforSept += sale;
                    }
                    else if (month == "10")
                    {
                        sumforOct += sale;
                    }
                    else if (month == "11")
                    {
                        sumforNov += sale;
                    }
                    else
                    {
                        sumforDec += sale;
                    }
                    sum += sale;
                }
                
               

            }

            Console.WriteLine($"The total shipped sales for 2003 is {sumfor2003.ToString("C")}");
            Console.WriteLine($"The total shipped sales for 2004 is {sumfor2004.ToString("C")}");
            Console.WriteLine($"The total shipped sales for 2005 is {sumfor2005.ToString("C")}");

            Console.WriteLine($"The total shipped sales for January is {sumforJan.ToString("C")}");
            Console.WriteLine($"The total shipped sales for February is {sumforFeb.ToString("C")}");
            Console.WriteLine($"The total shipped sales for March is {sumforMarch.ToString("C")}");
            Console.WriteLine($"The total shipped sales for April is {sumforApril.ToString("C")}");
            Console.WriteLine($"The total shipped sales for May is {sumforMay.ToString("C")}");
            Console.WriteLine($"The total shipped sales for June is {sumforJune.ToString("C")}");
            Console.WriteLine($"The total shipped sales for July is {sumforJuly.ToString("C")}");
            Console.WriteLine($"The total shipped sales for August is {sumforAug.ToString("C")}");
            Console.WriteLine($"The total shipped sales for September is {sumforSept.ToString("C")}");
            Console.WriteLine($"The total shipped sales for October is {sumforOct.ToString("C")}");
            Console.WriteLine($"The total shipped sales for November is {sumforNov.ToString("C")}");
            Console.WriteLine($"The total shipped sales for December is {sumforDec.ToString("C")}");

            Console.WriteLine($"Total sales is {sum.ToString("C2")}.");

            Console.ReadKey();
        }
    }   
}