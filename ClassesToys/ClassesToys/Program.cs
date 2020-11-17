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
            MyToy.updatenotes("Something Helpful");
            Console.WriteLine($"The Manufacturer of the toy {MyToy.Name} is {MyToy.Manufacturer} and the isle number for the toy is {MyToy.GetAisle()}. The price is {MyToy.Price}, and the notes on it are {MyToy.getnotes()}.");

            Toy Toy1 = new Toy();
            Toy1.Manufacturer = "FisherPrice";
            Toy1.Name = "Doll";
            Toy1.Price = 10.00;
            Toy1.updatenotes("Something Not That Helpful");
            Console.WriteLine($"The Manufacturer of the toy {Toy1.Name} is {Toy1.Manufacturer} and the isle number for the toy is {Toy1.GetAisle()}. The price is {Toy1.Price}, and the notes on it are {Toy1.getnotes()}.");

            Toy Toy2 = new Toy();
            Toy2.Manufacturer = "acomapny";
            Toy2.Name = "stuffed toy";
            Toy2.Price = 5.00;
            Toy2.updatenotes("Something A Little Helpful");
            Console.WriteLine($"The Manufacturer of the toy {Toy2.Name} is {Toy2.Manufacturer} and the isle number for the toy is {Toy2.GetAisle()}. The price is {Toy2.Price}, and the notes on it are {Toy2.getnotes()}.");

            Toy Toy4 = new Toy();
            Toy4.Manufacturer = "toysrus";
            Toy4.Name = "Frisbee";
            Toy4.Price = 2.00;
            Toy4.updatenotes("Something almost Helpful");
            Console.WriteLine($"The Manufacturer of the toy {Toy4.Name} is {Toy4.Manufacturer} and the isle number for the toy is {Toy4.GetAisle()}. The price is {Toy4.Price}, and the notes on it are {Toy4.getnotes()}.");

            ToyBox MyToyBox = new ToyBox();
            MyToyBox.Toys.Add(MyToy);
            MyToyBox.Toys.Add(Toy2);
            Toy randomToy = MyToyBox.GetRandomToy();
            Console.WriteLine($"The Manufacturer of the toy {randomToy.Name} is {randomToy.Manufacturer} and the isle number for the toy is {randomToy.GetAisle()}. The price is {randomToy.Price}, and the notes on it are {randomToy.getnotes()}.");

            ToyBox ToyContainer = new ToyBox();
            ToyContainer.Toys.Add(Toy1);
            MyToyBox.Toys.Add(Toy4);
            Toy rToy = ToyContainer.GetRandomToy();
            Console.WriteLine($"The Manufacturer of the toy {rToy.Name} is {rToy.Manufacturer} and the isle number for the toy is {rToy.GetAisle()}. The price is {rToy.Price}, and the notes on it are {rToy.getnotes()}.");
           
            Console.ReadLine();

        }
    }
}