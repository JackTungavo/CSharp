using System;

namespace OrderApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Order myOrder = new Order();
            myOrder.AddAmount(50);
            myOrder.ApplyDiscount(10);
            myOrder.AddAmount(30);
            Console.WriteLine(myOrder.FriendlyTotal());
            Discounter myDiscounter = new Discounter(20);
            Console.WriteLine("Discounted Value 1: $" + myDiscounter.ApplyTo(100));
            Console.WriteLine("Discounted Value 2: $" + myDiscounter.ApplyTo(200));
        }
    }
    class Order
    {
        private int total;
        public void AddAmount(int amount)
        {
            total += amount;
        }
        public void ApplyDiscount(int discount)
        {
            total -= discount;
        }
        public int GetTotal()
        {
            return total;
        }
        public string FriendlyTotal()
        {
            return $"Thanks! The total value of your order is £{total}.";
        }
    }

    class Discounter
    {
        private int discount;
        public Discounter(int discount)
        {
            this.discount = discount;
        }
        public int ApplyTo(int value)
        {
            return value - discount;
        }
    }
}
