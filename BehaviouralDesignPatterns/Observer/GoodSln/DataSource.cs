using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Observer.GoodSln
{
    public class DataSource : Subject 
    {
        private List<int> _values = new List<int>();
        public List<int> GetValues()
        {
            return _values;
        }
        public void SetValues(List<int> values)
        {
            _values = values;

            NotifyObserver();
            
        }
    }
}
// CLIENTSIDECODE
// var dataSource = new DataSource();
// var sheet2 = new Sheet2(dataSource);
// var barChart = new BarChart(dataSource);

// dataSource.AddObserver(sheet2);
// dataSource.AddObserver(barChart);
// dataSource.SetValues([5,10,15,20]);
