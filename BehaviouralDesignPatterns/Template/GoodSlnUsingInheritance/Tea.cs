using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Template.GoodSlnUsingInheritance
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing Tea for 3 mins");
        }
        protected override void AddCondiments()
        {
            if (CustomerWantsCondiments())
            {
                System.Console.WriteLine("Adding lemon to your tea");
            }
        }
        private bool CustomerWantsCondiments()
        {
            System.Console.WriteLine("Would you like lemon added to your tea (y/n)");
            string input = Console.ReadLine();
            return input.ToLower() == "y";

        }

    }
}