using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectOfFactory
{
    public class Cake : IFood
    {
        public void GetType()
        {
            Console.WriteLine("The factory returned class Cake '\n' Someone ordered a Dessert!");
        }
    }
}
