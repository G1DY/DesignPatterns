using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BehaviouralDesignPatterns.Mediator
{
    // centere all the business logic
    public class PostDialogueBox : DialogueBox
    {
        // All the ui fields
        private ListBox _postslistBox;
        private TextBox _titletextBox;
        private Button _savebutton;

        public PostDialogueBox()
        {
            _postslistBox = new ListBox(this);
            _titletextBox = new TextBox(this);
            _savebutton = new Button(this); 
            _savebutton.SetEnabled(false);

        }
        public void SimulatorUserInteraction()
        {
            _postslistBox.SetSelection("Post 2");
            _titletextBox.SetText("");
            System.Console.WriteLine("Title textBox : " + _titletextBox.GetText());
            System.Console.WriteLine("Button enabled: " + _savebutton.isEnabled());
        }
        public override void Changed(UIControl uIControl)
        {
            if (uIControl == _postslistBox)
            {
                HandlePostChanged();
            }
            else if (uIControl == _titletextBox)
            {;
                HandleTitleChanged();
            }
        }
        private void HandlePostChanged()
        {
            _titletextBox.SetText(_postslistBox.GetSelection());
            _savebutton.SetEnabled(true);
        }
        private void HandleTitleChanged()
        {
            bool isTitleEmpty = _titletextBox.GetText() == "";
            _savebutton.SetEnabled(!isTitleEmpty);
        }
    }
}
// CLIENTSIDECODE:
// var postsDialogueBox = new PostDialogueBox();
// postsDialogueBox.SimulatorUserInteraction();
