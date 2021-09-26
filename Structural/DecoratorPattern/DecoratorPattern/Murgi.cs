using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Murgi : FoodDecorator
    {
        public Murgi(Food plainFood) : base(plainFood)
        {

        }

        public string PrepareFood()
        {
            return plainFood.PrepareFood() + "Murgi ready";
        }
        public double FoodPrice()
        {
            return plainFood.FoodPrice() + 90;
        }

    }
}
