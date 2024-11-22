using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Template.GoodSlnUsingInheritance
{
    public abstract class Beverage
    {
        public void MakeBeverage()
        {
            BoilWater();
            PourWaterIntoCup();
            Brew();
            AddCondiments();
        }
        private void BoilWater()
        {
            System.Console.WriteLine("Boiling Water");
        }
        private void PourWaterIntoCup()
        {
            System.Console.WriteLine("Pouring Water into Cup");
        }
        protected abstract void Brew();
        protected virtual void AddCondiments() {}
    }
}