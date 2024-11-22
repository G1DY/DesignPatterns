using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Observer.BadSln
{
    public class DataSource
    {
        private List<int> _values = new List<int>();
        private List<Object> _dependents = new List<Object>();
        public List<int> GetValues()
        {
            return _values;
        }
        public void SetValues(List<int> values)
        {
            _values = values;
            foreach(var dependent in _dependents)
            {
                if (dependent is Sheet2)
                {
                    (dependent as Sheet2).CalculateTotal(_values);
                }
                else if (dependent is Barchart)
                {
                    (dependent as Barchart).Render(_values);
                }
            }
        }
        public void AddDependents(Object dependent)
        {
            _dependents.Add(dependent);
        }
        public void RemoveDependents(Object dependent)
        {
            _dependents.Remove(dependent);
        }
    }
}
// CLIENTSIDECODE:
// var dataSource = new DataSource();
// var sheet2 = new Sheet2();
// var barChart = new Barchart();

// dataSource.AddDependents(sheet2);
// dataSource.AddDependents(barChart);

// dataSource.SetValues([5,10,15,20]);
// dataSource.GetValues();