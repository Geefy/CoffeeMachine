using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class DripCoffeeMachine : BeverageMachine
    {
        public DripCoffeeMachine(float containerSize) : base(containerSize)
        {
        }

        public override Beverage MakeBeverage()
        {
            if (IsTurnedOn)
                beverage = new Coffee();

            return beverage;
        }
    }
}
