using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    abstract class BeverageMachine : Machine
    {
        bool hasFilter;
        public bool HasFilter { get { return hasFilter; } set { hasFilter = value; } }
        protected Beverage beverage;
        private Container internalContainer;
        public Container externalContainer;
        
        public BeverageMachine(float containerSize)
        {
            internalContainer = new Container(containerSize);
        }

        public override void TurnOff()
        {
            //Turns off machine
        }

        public override void TurnOn()
        {
            //Turn on machine
            isTurnedOn = true;
        }

        public abstract Beverage MakeBeverage();

        public virtual Container FillInternalContainer(float amount, Beverage beverage)
        {


            internalContainer.Fill(amount);
            internalContainer.Beverage = beverage;

            return internalContainer;
        }
    }
}
