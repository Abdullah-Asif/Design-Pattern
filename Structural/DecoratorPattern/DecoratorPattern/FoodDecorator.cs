using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FoodDecorator : IFood
    {
        public IFood plainFood;
        public FoodDecorator(IFood plainFood)
        {
            this.plainFood = plainFood;
        }
        public virtual double FoodPrice()
        {
            return plainFood.FoodPrice();
        }

        public virtual string PrepareFood()
        {
            return plainFood.PrepareFood();
        }
    }
}
