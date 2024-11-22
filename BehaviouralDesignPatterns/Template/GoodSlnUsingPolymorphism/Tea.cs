using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Template.GoodSlnUsingPolymorphism
{
    public class Tea : IBeverage
    {
        public void Prepare()
        {
            Brew();
            AddCondiments();
        }
        private void Brew()
        {
            System.Console.WriteLine("Brewing Tea for 3 mins");
        }
        private void AddCondiments()
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