using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.AbstractProducts;
using AbstractFactory.Products;

namespace AbstractFactory
{
    abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Pants CreatePants();
    }
}
