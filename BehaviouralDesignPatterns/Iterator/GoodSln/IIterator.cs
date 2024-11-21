using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Iterator.GoodSln
{
    public interface IIterator<T>
    {
        void Next();
        T Current();
        bool HasNext();
    }
}