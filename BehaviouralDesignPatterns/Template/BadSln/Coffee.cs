using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Template.BadSln
{
    public class Coffee
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
        private void Brew()
        {
            System.Console.WriteLine("Brewing Tea for 5 mins");
        }
        private void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                System.Console.WriteLine("Adding Cream to your Coffee");
            }
        }
        private bool CustomerWantsCondiments()
        {
            System.Console.WriteLine("Would you like Cream added to your Coffee (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";

        }
    }
}