using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class Person
    {
        public Container cup = new Container(1);

        public void FillCup(Beverage beverage)
        {
            cup.Beverage = beverage;
        }

        public void Drink()
        {
            Console.WriteLine("I drink " + cup.Beverage.Name);
        }
    }
}
