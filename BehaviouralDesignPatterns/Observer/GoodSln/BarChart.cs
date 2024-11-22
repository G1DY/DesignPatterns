using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Observer.GoodSln
{
    public class BarChart : IObserver
    {
        // field to get values from datasource
        private DataSource _dataSource;
        public BarChart(DataSource datasource)
        {
            _dataSource = datasource;           
        }
        public void Update()
        {
            System.Console.WriteLine("Rendering Barchart with values");
        }
    }
}