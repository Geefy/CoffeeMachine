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

        public override void MakeBeverage()
        {
            //Makes coffee if machine is turned on
            if (IsTurnedOn)
                beverage = new Coffee();

            
        }

        public void InsertFilter()
        {
            HasFilter = true;
        }


    }
}
