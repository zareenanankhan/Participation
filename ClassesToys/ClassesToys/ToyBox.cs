using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesToys
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
        }

        public Toy GetRandomToy()
        {
            Random rnd = new Random();
            int result = rnd.Next(0, Toys.Count);
            return Toys[result];
        }

        
    }
}
