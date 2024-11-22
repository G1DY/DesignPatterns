using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Template.GoodSlnUsingPolymorphism
{
    public class Camomile : IBeverage
    {
        public void Prepare()
        {
            Brew();
        }
        private void Brew()
        {
            System.Console.WriteLine("Brewing Tea for 3 mins");
        }
    }
}