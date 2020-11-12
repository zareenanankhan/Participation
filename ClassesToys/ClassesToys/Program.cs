using System;
using System.Collections.Generic;

namespace ClassesToys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy MyToy = new Toy();
            MyToy.Manufacturer = "Toyota";
            MyToy.Name = "Car";
            MyToy.Price = 20.00;
            MyToy.Notes = "Something Helpful";
            Console.WriteLine($"The Manufacturer of the toy {MyToy.Name} is {MyToy.Manufacturer} and the isle number for the toy is {MyToy.GetAisle()}. The price is {MyToy.Price}, and the notes on it are {MyToy.Notes}.");

            Toy Toy1 = new Toy();
            Toy1.Manufacturer = "FisherPrice";
            Toy1.Name = "Doll";
            Toy1.Price = 10.00;
            Toy1.Notes = "Something Not That Helpful";
            Console.WriteLine($"The Manufacturer of the toy {Toy1.Name} is {Toy1.Manufacturer} and the isle number for the toy is {Toy1.GetAisle()}. The price is {Toy1.Price}, and the notes on it are {Toy1.Notes}.");

            Toy Toy2 = new Toy();
            Toy2.Manufacturer = "FisherPrice";
            Toy2.Name = "Doll";
            Toy2.Price = 10.00;
            Toy2.Notes = "Something Not That Helpful";
            Console.WriteLine($"The Manufacturer of the toy {Toy2.Name} is {Toy2.Manufacturer} and the isle number for the toy is {Toy2.GetAisle()}. The price is {Toy2.Price}, and the notes on it are {Toy2.Notes}.");

            Toy Toy4 = new Toy();
            Toy4.Manufacturer = "FisherPrice";
            Toy4.Name = "Doll";
            Toy4.Price = 10.00;
            Toy4.Notes = "Something Not That Helpful";
            Console.WriteLine($"The Manufacturer of the toy {Toy4.Name} is {Toy4.Manufacturer} and the isle number for the toy is {Toy4.GetAisle()}. The price is {Toy4.Price}, and the notes on it are {Toy4.Notes}.");

            ToyBox MyToyBox = new ToyBox();
            string[] Range = { "doll", "car", "action figure" };
            MyToyBox.Toys.AddRange(Range);
            Console.WriteLine($"The toys in the toybox are {MyToyBox.Toys}");

            ToyBox ToyContainer = new ToyBox();
            string[] Range1 = { "Mario", "Luigi", "Baby Peach" };
            MyToyBox.Toys.AddRange(Range1);
            Console.WriteLine($"The toys in the toybox are {ToyContainer.Toys}");

            ToyBox Toybox1 = new ToyBox();
            string[] Range1 = { "a", "b", "c" };
            MyToyBox.Toys.AddRange(Range1);
            Console.WriteLine($"A toy from the toybox is {Toybox1.GetRandomToy()}");

            ToyBox Toybox2 = new ToyBox();
            string[] Range2 = { "d", "e", "f" };
            MyToyBox.Toys.AddRange(Range2);
            Console.WriteLine($"A toy from the toybox is {Toybox1.GetRandomToy()}");

            Console.ReadLine();

        }
    }
}