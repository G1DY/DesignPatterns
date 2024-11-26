using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Visitor
{
    public class RestaurantClient : Client
    {
        public RestaurantClient(string name, string email) : base(name, email)
        {
        }

        public override void SendEmail()
        {
            System.Console.WriteLine("Sending law marketing tips email to " + _email);
        }
    }
}