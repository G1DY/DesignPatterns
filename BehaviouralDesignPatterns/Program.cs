using BehaviouralDesignPatterns.Visitor.GoodSln;

var clients = new List<Client> {
    new RetailC("Gideon", "123@gmail.com"),
    new LawC("K&K", "k&k@lawfirm.com"),
    new RestaurantC("kfc", "kfc@gmail.com"),
};
foreach (var client in clients)
{
    client.Accept(new EmailVisitor());
    client.Accept(new PDFVisitor());
}