using BehaviouralDesignPatterns.Command.UndoRedo;

var htmldoc = new HtmlDocument();
var history = new History();
htmldoc.Content = "Command Pattern";
System.Console.WriteLine(htmldoc.Content);

var itallic = new ItallicCommand(htmldoc, history);
itallic.Execute();
System.Console.WriteLine(htmldoc.Content);

var undoCommand = new UndoCommand(history);
undoCommand.Execute();
System.Console.WriteLine(htmldoc.Content);
