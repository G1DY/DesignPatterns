using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Visitor.GoodSln
{
    // what is really a visitor pattern?
    public interface Visitor
    {
        void VisitRetail(RetailC retailC);
        void VisitLaw(LawC lawC);
        void VisitRestaurant(RestaurantC restaurantC);
    }
}
// CLIENTSIDECODE:
// using BehaviouralDesignPatterns.Visitor.GoodSln;

// var clients = new List<Client> {
//     new RetailC("Gideon", "123@gmail.com"),
//     new LawC("K&K", "k&k@lawfirm.com"),
//     new RestaurantC("kfc", "kfc@gmail.com"),
// };
// foreach (var client in clients)
// {
//     client.Accept(new EmailVisitor());
//     client.Accept(new PDFVisitor());
// }