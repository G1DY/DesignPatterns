using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Template.GoodSlnUsingPolymorphism
{
    public class BeverageMaker
    {
        private IBeverage _beverage;
        public BeverageMaker(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public void Prepare()
        {
            // common methods
            BoilWater();
            PourWaterIntoCup();
            // Methods unique to the beverage
            _beverage.Prepare();

        }

        public void SetBeverage(IBeverage beverage)
        {
            _beverage = beverage;
        }
        private void BoilWater()
        {
            System.Console.WriteLine("Boiling Water");
        }
        private void PourWaterIntoCup()
        {
            System.Console.WriteLine("Pouring Water into Cup");
        }
    }
}
// CLIENTSIDECODE:
// var beverageMaker = new BeverageMaker(new Tea());
// beverageMaker.MakeBeverage();

// beverageMaker.SetBeverage(new Coffee());
// beverageMaker.MakeBeverage();