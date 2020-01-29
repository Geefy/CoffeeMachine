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

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
