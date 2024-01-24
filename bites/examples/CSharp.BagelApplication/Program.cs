using System;

namespace BagelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bagel myBagel = new Bagel();
            Console.WriteLine("Seeds: " + myBagel.Seeds());
            Console.WriteLine("Filling: " + myBagel.Filling());
            Console.WriteLine("Price: $" + myBagel.Price());
        }
    }

    class Bagel
    {
        public string Seeds()
        {
            return "Poppy seeds and sesame seeds";
        }
        public string Filling()
        {
            return "Cream cheese and smoked salmon";
        }
        {
            return 3;
        }
    }
}
