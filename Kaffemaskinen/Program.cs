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
            BeverageMachine coffeeMachine = new DripCoffeeMachine(3);
            BeverageMachine teaMachine = new TeaMachine(3);
            Person coffeePerson = new Person();
            Person teaPerson = new Person();

            //Coffee Person
            coffeeMachine.FillInternalContainer(3);
            coffeeMachine.TurnOn();
            coffeeMachine.MakeBeverage();
            coffeePerson.FillCup(coffeeMachine.ReturnBeverage(coffeePerson.cup.MaxLiters));
            coffeeMachine.TurnOff();
            coffeePerson.Drink();

            //Tea Person
            teaMachine.FillInternalContainer(3);
            teaMachine.TurnOn();
            teaMachine.MakeBeverage();
            teaPerson.FillCup(teaMachine.ReturnBeverage(teaPerson.cup.MaxLiters));
            teaMachine.TurnOff();
            teaPerson.Drink();
            Console.Read();
        }
    }
}
