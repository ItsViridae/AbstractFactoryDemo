using System;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is your Hipster Friend:");
            var hipsterFriend = new Client(new HipsterClothesFactory());
            hipsterFriend.DescribeWhatIAmWearing();

            Console.WriteLine("\n\nThis is your Fancy Friend:");
            var fancyFriend = new Client(new DressClothesFactory());
            fancyFriend.DescribeWhatIAmWearing();

            Console.ReadLine();
        }
    }
}
