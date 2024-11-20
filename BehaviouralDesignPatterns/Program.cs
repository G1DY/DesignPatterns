using BehaviouralDesignPatterns.Memento;

var editor= new Editor();
var history = new History(editor);
history.Backup();
editor.Title = "Test";
history.Backup();
editor.Content = "Hello there myname is Gideon";
history.Backup();
editor.Title = "Mementos";

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");

history.Undo();

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");

history.ShowHistory();

history.Undo();

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");

history.Undo();

System.Console.WriteLine($"Title: {editor.Title}");
System.Console.WriteLine($"Content: {editor.Content}");