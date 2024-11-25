using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BehaviouralDesignPatterns.Mediator.MediatorWithObserver.UIFramework;

namespace BehaviouralDesignPatterns.Mediator.MediatorWithObserver
{
    public class PostDialogueBox : DialogueBox
    {
        private ListBox _postslistBox;
        private TextBox _titletextBox;
        private Button _savebutton;

        public PostDialogueBox()
        {
            _postslistBox = new ListBox(this);
            _titletextBox = new TextBox(this);
            _savebutton = new Button(this); 
            // _savebutton.SetEnabled(false);

            _postslistBox.AddEventHandler(PostSelected);
            _titletextBox.AddEventHandler(TitleChanged);

        }
        public void SimulatorUserInteraction()
        {
            _postslistBox.SetSelection("Post 2");
            _titletextBox.SetText("");
            System.Console.WriteLine("Title textBox : " + _titletextBox.GetText());
            System.Console.WriteLine("Button enabled: " + _savebutton.isEnabled());
        }
    
        private void PostSelected()
        {
            _titletextBox.SetText(_postslistBox.GetSelection());
            _savebutton.SetEnabled(true);
        }
        private void TitleChanged()
        {
            bool isTitleEmpty = _titletextBox.GetText() == "";
            _savebutton.SetEnabled(!isTitleEmpty);
        }
    }
}