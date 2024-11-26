using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Visitor.GoodSln
{
    public interface Visitor
    {
        void VisitRetail(RetailC retailC);
        void VisitLaw(LawC lawC);
        void VisitRestaurant(RestaurantC restaurantC);
    }
}