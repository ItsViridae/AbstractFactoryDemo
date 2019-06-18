using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.AbstractProducts;
using AbstractFactory.Products;

namespace AbstractFactory.Factory
{
    class DressClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new DressShirt();
        }

        public override Pants CreatePants()
        {
            return new Slacks();
        }
    }
}
