using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Vorta : IFood
    {
        public double FoodPrice()
        {
            return 25;
        }

        public string PrepareFood()
        {
            return "Mama apner vat, vorta ";
        }
    }
}
