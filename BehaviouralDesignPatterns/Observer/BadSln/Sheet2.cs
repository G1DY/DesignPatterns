using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Observer.BadSln
{
    public class Sheet2
    {
        private int _total; //field for storing the total
        public int GetTotal()
        {
            return _total;
        }
        public int CalculateTotal(List<int> values)
        {
            var sum = 0;
            foreach (var value in values)
            {
                sum += value;
            }
            System.Console.WriteLine($"The total is {sum}");
            return sum;
        }
    }
}