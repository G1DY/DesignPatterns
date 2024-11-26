using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Visitor.GoodSln
{
    public class EmailVisitor : Visitor
    {
        public void VisitLaw(LawC lawC)
        {
            System.Console.WriteLine("Sending law marketing tips email to " + lawC.GetEmail());
        }

        public void VisitRestaurant(RestaurantC restaurantC)
        {
            System.Console.WriteLine("Sending Restaurant marketing tips email to " + restaurantC.GetEmail());
        }

        public void VisitRetail(RetailC retailC)
        {
            System.Console.WriteLine("Sending Retail marketing tips email to " + retailC.GetEmail());
        }
    }
}