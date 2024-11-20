using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Memento
{
    //memento class
    public class EditorState
    {
        private readonly string _content;
        private readonly string _title;
        
        //metadata
        public readonly  DateTime _stateCreatedAt;

        public EditorState(string content, string title)
        {
            _content = content;
            _title = title;
            _stateCreatedAt = DateTime.Now;
        }

        public string GetContent()
        {
            return _content;
        }
        public string GetTitle()
        {
            return _title;	
        }
        public DateTime GetDateTime()
        {
            return _stateCreatedAt;	
        }
        public string GetName()
        {
            return $"{_stateCreatedAt} / {_title}";
        }
    }
}