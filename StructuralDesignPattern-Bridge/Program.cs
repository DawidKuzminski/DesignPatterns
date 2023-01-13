using StructuralDesignPattern_Bridge.Abstraction;
using StructuralDesignPattern_Bridge.Implementation;

Console.WriteLine("Structural Design Pattern - Bridge");

var tv = new TV();
var tvRemoteControll = new RemoteControl(tv);

tvRemoteControll.ChannelDown();
tvRemoteControll.TogglePower();
tvRemoteControll.ChannelUp();
tvRemoteControll.VolumeUp();