using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Murgi : FoodDecorator
    {
        public Murgi(IFood plainFood) : base(plainFood)
        {

        }

        public override string PrepareFood()
        {
            return plainFood.PrepareFood() + "Murgi ready";
        }
        public override double FoodPrice()
        {
            return plainFood.FoodPrice() + 90;
        }

    }
}
