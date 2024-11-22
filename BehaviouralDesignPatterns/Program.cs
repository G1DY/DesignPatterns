using BehaviouralDesignPatterns.Command;

var light = new Light();
var remoteControl = new RemoteControl(light);

remoteControl.PressButton(true);
remoteControl.PressButton(false);