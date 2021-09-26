using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Food
    {
        public abstract string PrepareFood();
        public abstract double FoodPrice();
    }
}
