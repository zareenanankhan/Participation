using System;

namespace ClassesToys
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes;

        public string GetAisle()
        {
           string a= Manufacturer[0].ToString();

           Random rnd = new Random();
           int result = rnd.Next(1, 24);

           return a + result.ToString();

        }

        public Toy()
        {
            Name = " ";
            Price = 0;
            Notes = " ";
            Manufacturer = " ";
        }

    }
}