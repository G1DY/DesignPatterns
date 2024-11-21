using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.State.BadSln
{
    public class Document
    {
        public DocumentState State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public void Publish()
        {
            if (State == DocumentState.Draft)
            {
                State = DocumentState.Moderation;
            }
            else if (State == DocumentState.Moderation)
            {
                if (CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumentState.Publish;
                }
                else
                {
                    return;
                }
            }
            else if (State == DocumentState.Publish)
            {
                return;
            }
        }
    }
}