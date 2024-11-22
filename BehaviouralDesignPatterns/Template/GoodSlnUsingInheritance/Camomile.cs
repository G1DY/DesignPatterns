using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Template.GoodSlnUsingInheritance
{
    public class Camomile : Beverage
    {
        protected override void Brew()
        {
            System.Console.WriteLine("Brewing Camomile for 3 mins");
        }
    }
}