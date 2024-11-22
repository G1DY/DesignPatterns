using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Observer.BadSln
{
    public class Barchart
    {
        public void Render(List<int> values)
        {
            System.Console.WriteLine("Rendering Barchart with values");
        }
    }
}