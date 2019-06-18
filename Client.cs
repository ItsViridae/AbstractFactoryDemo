using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory
{
    class Client
    {
        private readonly Shirt _shirt;
        private readonly Pants _pants;

        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _pants = factory.CreatePants();
        }

        public void DescribeWhatIAmWearing()
        {
            Console.WriteLine($"I Like to wear {_shirt.GetType().Name} and {_pants.GetType().Name}.");
        }
    }
}
