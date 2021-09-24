using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectOfFactory
{
    public class FoodFactory
    {
        public IFood GetFood (string foodType)
        {
            switch(foodType)
            {
                case "Pizza":
                    return new Pizza();

                case "Cake":
                    return new Cake();
            }
            return null;
        }
    }
}
