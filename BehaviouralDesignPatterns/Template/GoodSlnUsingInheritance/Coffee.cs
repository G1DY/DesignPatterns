using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Template.GoodSlnUsingInheritance
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing Coffee for 5 mins");
        }
        protected override void AddCondiments()
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