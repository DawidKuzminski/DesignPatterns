using StructuralDesignPattern_Bridge.Implementation;

namespace StructuralDesignPattern_Bridge.Abstraction;
internal interface IRemoteControl
{
	public void TogglePower();
	public void VolumeDown();
	public void VolumeUp();
	public void ChannelDown();
	public void ChannelUp();
}
