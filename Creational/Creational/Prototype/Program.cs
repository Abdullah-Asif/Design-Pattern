using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            person1.Name = "Asif";
            person1.Email = "asif123@gmail.com";

            Console.WriteLine($"Name : {person1.Name}, Email : {person1.Email}");

            var person2 = person1.Clone() as Person;

            Console.WriteLine($"Name : {person2.Name}, Email : {person2.Email}");
        }
    }
}
