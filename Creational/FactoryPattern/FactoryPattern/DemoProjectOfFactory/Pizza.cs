using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectOfFactory
{
    public class Pizza : IFood
    {
        public void GetType()
        {
            Console.WriteLine("The factory returned class Pizza '\n' Someone ordered a Fast Food!");

    }
    }
}
