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
        
        public BeverageMachine(float containerSize)
        {
            internalContainer = new Container(containerSize);
        }


        public abstract void MakeBeverage();


        public virtual Beverage ReturnBeverage(float amount)
        {
            if (internalContainer.CurrLiters > amount)
            {

            internalContainer.CurrLiters -= amount;
            return beverage;
            }
            return null;
        }

        public virtual void FillInternalContainer(float amount)
        {
            internalContainer.Fill(amount);
        }
    }
}
