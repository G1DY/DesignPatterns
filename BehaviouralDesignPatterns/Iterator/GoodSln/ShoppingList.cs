using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Iterator.GoodSln
{
    public class ShoppingList
    {
        private List<string> _list = new List<string>(); 
        public void Push(string itemName)
        {
            _list.Add(itemName);
        }

        public string Pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public List<string> GetList()
        {
            return _list;
        }
        // CreateIterator method
        public IIterator<string> CreateIterator()
        {
            return new ListIterator(this);
        }
        // create nested iterator class
        private class ListIterator : IIterator<string>
        {
            private ShoppingList _shoppingList;
            private int _index;

            public ListIterator(ShoppingList shoppingList)
            {
                _shoppingList = shoppingList;
                _index = 0;
            }
            public string Current()
            {
                return _shoppingList._list[_index];
            }

            public bool HasNext()
            {
                return _index < _shoppingList._list.Count;
            }

            public void Next()
            {
                _index++;
            }
        }
    }
}
