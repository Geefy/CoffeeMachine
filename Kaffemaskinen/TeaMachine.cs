using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class TeaMachine : BeverageMachine
    {
        public TeaMachine(float containerSize) : base(containerSize)
        {
        }

        public override void MakeBeverage()
        {
            if (IsTurnedOn)
            {
                beverage = new Tea();
            }
        }
    }
}
