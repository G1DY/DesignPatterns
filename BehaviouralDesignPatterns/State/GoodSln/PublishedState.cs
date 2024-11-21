using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.State.GoodSln
{
    public class PublishedState : State
    {
        // reference to the document class
        private Document _document;

        // Constractor to initialize the document
        public PublishedState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            return;
            // does nothing
        }
    }
}