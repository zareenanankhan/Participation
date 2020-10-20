using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string animaltype;
            string animalsound;

            Console.WriteLine("Please enter a type of animal");
            animaltype = Console.ReadLine();

            animalsound=Speak(animaltype);

            Console.WriteLine(animalsound);

            Console.ReadKey();

        }


        static string Speak(string animaltype)
            {
           
            string animalsound;

            if (animaltype == "dog")
            {
                animalsound = "bark";
                
            }
            else if (animaltype == "monkey")
            {
                animalsound = "chatter";
               
            }
            else if (animaltype == "goat")
            {
                animalsound = "bleat";

            }
            else
            {
                animalsound = "Animal not found";
            }

            return animalsound;

            Console.ReadKey();

            }
        
    }
}
