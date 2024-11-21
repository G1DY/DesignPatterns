using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.State.GoodSln
{
    public class ModerationState : State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            if (_document.CurrentUserRole == UserRoles.Admin)
            {
                _document.State = new PublishedState(_document);
                System.Console.WriteLine("Document moved to publishing");
            }
        }
    }
}