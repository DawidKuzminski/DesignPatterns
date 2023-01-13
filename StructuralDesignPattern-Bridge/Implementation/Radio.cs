namespace StructuralDesignPattern_Bridge.Implementation;
internal class Radio : IDevice
{
	private int _volume;
	private int _channel;
	private bool _isEnabled;

	public int Volume
	{
		get
		{
			return _volume;
		}
		set
		{
			_volume = value;
			Console.WriteLine($"Radio: Volume changed - Current value: {_volume}");
		}
	}

	public int Channel
	{
		get
		{
			return _channel;
		}
		set
		{
			_channel = value;
			Console.WriteLine($"Radio: Channel changed - Current value: {_channel}");
		}
	}

	public bool IsEnabled
	{
		get
		{
			return _isEnabled;
		}
		set
		{
			Console.WriteLine($"Radio: Power is {_isEnabled} will be changed to: {value}");
			_isEnabled = value;
		}
	}
}
