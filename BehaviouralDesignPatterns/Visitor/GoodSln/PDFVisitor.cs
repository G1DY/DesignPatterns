using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Visitor.GoodSln
{
    public class PDFVisitor : Visitor
    {
        public void VisitLaw(LawC lawC)
        {
            System.Console.WriteLine("Sending law PDF marketing tips");
        }

        public void VisitRestaurant(RestaurantC restaurantC)
        {
            System.Console.WriteLine("Sending Restaurant PDF marketing tips");
        }

        public void VisitRetail(RetailC retailC)
        {
            System.Console.WriteLine("Sending Retail PDF marketing tips");
        }
    }
}