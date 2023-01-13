using StructuralDesignPattern_Bridge.Implementation;

namespace StructuralDesignPattern_Bridge.Abstraction;
internal class RemoteControl : IRemoteControl
{
	private readonly IDevice _device;
	public RemoteControl(IDevice device)
	{
		_device = device;
	}

	public void TogglePower()
	{
		Console.WriteLine("RemoteControl: Toggle Power");
		_device.IsEnabled = !_device.IsEnabled;
	}

	public void VolumeDown()
	{
		Console.WriteLine("RemoteControl: Volume Down");
		if(_device.IsEnabled)
		{
			_device.Volume--;
		}
	}

	public void VolumeUp()
	{
		Console.WriteLine("RemoteControl: Volume Up");
		if (_device.IsEnabled)
		{
			_device.Volume++;
		}
	}

	public void ChannelDown()
	{
		Console.WriteLine("RemoteControl: Channell Down");
		if (_device.IsEnabled)
		{
			_device.Channel--;
		}
	}

	public void ChannelUp()
	{
		Console.WriteLine("RemoteControl: Channel Up");
		if (_device.IsEnabled)
		{
			_device.Channel++;
		}
	}
}
