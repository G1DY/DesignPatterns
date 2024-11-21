using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BehaviouralDesignPatterns.State.BadSln;

namespace BehaviouralDesignPatterns.State.GoodSln
{
    public class Draft : State
    {
        private Document _document;
        public Draft(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            _document.State = new ModerationState(_document);
        }
    }
}