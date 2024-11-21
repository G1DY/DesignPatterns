using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BehaviouralDesignPatterns.State.BadSln;

namespace BehaviouralDesignPatterns.State.GoodSln
{
    public class Document
    {
        public State State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public Document(UserRoles currentUserRole)
        {
            State = new Draft(this);
            CurrentUserRole = currentUserRole;
        }
        public void Publish()
        {
            State.Publish();
        }
    }
}