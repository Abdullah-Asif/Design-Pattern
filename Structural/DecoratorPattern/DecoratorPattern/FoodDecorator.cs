using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FoodDecorator : Food
    {
        public Food plainFood;
        public FoodDecorator(Food plainFood)
        {
            this.plainFood = plainFood;
        }
        public override double FoodPrice()
        {
            return plainFood.FoodPrice();
        }

        public override string PrepareFood()
        {
            return plainFood.PrepareFood();
        }
    }
}
