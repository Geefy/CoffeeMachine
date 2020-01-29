using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageMachine machine = new DripCoffeeMachine(3);
            Person person = new Person();
            machine.TurnOn();
            person.FillCup(machine.MakeBeverage());
            machine.TurnOff();
            person.Drink();
            Console.Read();
        }
    }
}
