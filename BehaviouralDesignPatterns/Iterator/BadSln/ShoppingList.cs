using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Iterator.BadSln
{
    public class ShoppingList
    {
        private List<string> _list = new List<string>(); //if we change the data structure i.e {private string[] list = new string[50]} it will affect the client

        public void push(string itemName)
        {
            _list.Add(itemName);
        }

        public string pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public List<string> GetList()
        {
            return _list;
        }
    }
}