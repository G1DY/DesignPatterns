using BehaviouralDesignPatterns.State.GoodSln;

var doc = new Document(UserRoles.Admin);
System.Console.WriteLine(doc.State);

doc.Publish();
System.Console.WriteLine(doc.State);

doc.Publish();
System.Console.WriteLine(doc.State);