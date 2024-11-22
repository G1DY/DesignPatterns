using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Command.UndoRedo
{
    // this class implements our business logic/ business layer of our application 
    // it knows nothing about the commands
    public class HtmlDocument
    {
        public string Content { get; set; }
        public void MakeItallic()
        {
            Content = "<i>" + Content + "</i>";
        }
    }
}

/*
CLIENTSIDECODE
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
*/