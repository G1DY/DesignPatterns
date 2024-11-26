using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BehaviouralDesignPatterns.Mediator.MediatorWithObserver.UIFramework;

namespace BehaviouralDesignPatterns.MediatorWithObserver
{
    public class PostsDialogueBox
    {
        private ListBox _postListBox;
        private TextBox _titleTextBox;
        private Button _saveButton;
        public PostsDialogueBox()
        {
            _postListBox = new ListBox();
            _titleTextBox = new TextBox();
            _saveButton = new Button();

            _postListBox.AddEventHandler(PostChanged);
            _titleTextBox.AddEventHandler(TitleChanged);
        }
        public void SimulatorUserInteraction()
        {
            _postListBox.SetSelection("Post 2");
            _titleTextBox.SetText("");
            System.Console.WriteLine("Title textBox : " + _titleTextBox.GetText());
            System.Console.WriteLine("Button enabled: " + _saveButton.IsEnabled());
        }
        public void PostChanged()
        {
            _titleTextBox.SetText(_postListBox.GetSelection());
            _saveButton.SetEnabled(true);
        }
        public void TitleChanged()
        {
            bool isTitleEmpty = _titleTextBox.GetText() == "";
            _saveButton.SetEnabled(!isTitleEmpty);
        }
    }
}