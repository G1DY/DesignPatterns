using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Memento
{
    //Originator
    public class Editor
    {
        public string Title { get; set;}
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Title, Content);
        }
        public void Restore(EditorState state)
        {
           Title = state.GetTitle();
           Content = state.GetContent(); 
        }
    }
}