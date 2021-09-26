using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mach : FoodDecorator
    {
        public Mach(IFood plainFood) : base(plainFood)
        {

        }

        public override string PrepareFood()
        {
            return plainFood.PrepareFood() + "Mach ready";
        }
        public override double FoodPrice()
        {
            return plainFood.FoodPrice() + 60;
        }

    }
}
