using System;

namespace DemoProjectOfFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Food Menu");
            Console.WriteLine("1. Cake");
            Console.WriteLine("2. Pizza");
            
            FoodFactory factory = new FoodFactory();
            IFood food;
            
            string type = Console.ReadLine();

            food = factory.GetFood(type);
            food.GetType();

        }
    }
}
