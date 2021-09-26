using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mach : FoodDecorator
    {
        public Mach(Food plainFood) : base(plainFood)
        {

        }

        public string PrepareFood()
        {
            return plainFood.PrepareFood() + "Mach ready";
        }
        public double FoodPrice()
        {
            return plainFood.FoodPrice() + 60;
        }

    }
}
