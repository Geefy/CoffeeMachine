using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class EspressoMachine : BeverageMachine
    {
        public EspressoMachine(float containerSize) : base(containerSize)
        {
        }

        public override void MakeBeverage()
        {
            if (isTurnedOn)
            {
                this.beverage = new Espresso();
            }
        }
    }
}
