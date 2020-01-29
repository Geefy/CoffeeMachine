using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class Container
    {
        private float maxLiters;
        private float currLiters;
        private Beverage beverage;

        public float CurrLiters { get { return currLiters; } set { currLiters = value; } }
        public Beverage Beverage { get { return beverage; } set { beverage = value; } }

        public Container(float maxCapacity)
        {
            this.maxLiters = maxCapacity;
        }

        public void Fill(float amount)
        {
            if (maxLiters >= currLiters)
            {
                for (int i = 0; i < amount; i++)
                {
                    currLiters++;
                }
            }
        }
    }
}
