using BehaviouralDesignPatterns.Command.GoodSln;

var light = new Light();
var remote = new RemoteControl(new TurnOnCommand(light));
remote.PressButton();
remote.SetCommand(new DimCommand(light));
remote.PressButton();