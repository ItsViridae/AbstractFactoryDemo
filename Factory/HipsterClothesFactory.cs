using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.AbstractProducts;
using AbstractFactory.Products;

namespace AbstractFactory.Factory
{
    class HipsterClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new Sleaveless();
        }

        public override Pants CreatePants()
        {
            return new SkinnyJeans();
        }
    }
}
