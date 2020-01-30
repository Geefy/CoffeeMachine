using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    abstract class Machine
    {
        protected bool isTurnedOn;
        public bool IsTurnedOn { get { return isTurnedOn; } }

        public void TurnOff()
        {
            //Turns off machine
            isTurnedOn = true;
        }

        public void TurnOn()
        {
            //Turn on machine
            isTurnedOn = true;
        }
    }
}
