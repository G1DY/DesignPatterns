using BehaviouralDesignPatterns.Iterator.GoodSln;

var shoppinglist = new ShoppingList();
shoppinglist.Push("Mango");
shoppinglist.Push("Banana");
shoppinglist.Push("Apple");

var iterator = shoppinglist.CreateIterator();

while (iterator.HasNext())
{
    System.Console.WriteLine(iterator.Current());
    iterator.Next();
}