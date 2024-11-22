using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Observer.GoodSln
{
    public class Sheet2 : IObserver
    {
        private int _total;
        private DataSource _dataSource;
        public Sheet2(DataSource dataSource)
        {
            _dataSource = dataSource;
        }
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
            System.Console.WriteLine("Total is: " + sum);
            return sum;
        }
        public void Update()
        {
            _total = CalculateTotal(_dataSource.GetValues());
        }
    }
}