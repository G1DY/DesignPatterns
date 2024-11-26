using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Visitor.GoodSln
{
    public class RestaurantC : Client
    {
        public RestaurantC(string name, string email) : base(name, email)
        {
        }

        public override void Accept(Visitor visitor)
        {
            visitor.VisitRestaurant(this);
        }
    }
}