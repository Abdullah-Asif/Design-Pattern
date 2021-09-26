using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Mamaaaa, ki khaiben ???");
                Console.WriteLine("1. vorta");
                Console.WriteLine("2. mach");
                Console.WriteLine("3. murgi");
                Console.WriteLine("4. exit");
                Console.WriteLine("Enter your choice");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "vorta":
                        {
                            var khabar = new Vorta();
                            Console.WriteLine(khabar.PrepareFood() + " ready");
                            Console.WriteLine("mamaa bill hoiche apner " + khabar.FoodPrice() + " Taka");

                        }
                        break;

                    case "mach":
                        {
                            var khabar = new Mach(new Vorta());
                            Console.WriteLine(khabar.PrepareFood());
                            Console.WriteLine("mamaa bill hoiche apner " + khabar.FoodPrice() + " Taka");

                        }
                        break;

                    case "murgi":
                        {
                            var khabar = new Murgi(new Vorta());
                            Console.WriteLine(khabar.PrepareFood());
                            Console.WriteLine("mamaa bill hoiche apner " + khabar.FoodPrice() + " Taka");

                        }
                        break;

                    case "exit":
                        {
                            Console.WriteLine("Mama abar aisen");

                        }
                        break;

                    default:
                        {

                            Console.WriteLine("Mama " + choice + " seshhh!!!!");
                        }
                        break;
                }
        }
    }
}
