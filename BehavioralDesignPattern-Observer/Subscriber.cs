using BehavioralDesignPattern_Observer.Abstractions;

namespace BehavioralDesignPattern_Observer;
internal class Subscriber : ISubscriber
{
	public string Name { get; set; }

	public Subscriber(string name)
	{
		Name = name;
	}

	public void Update(string context)
	{
		Console.WriteLine($"Subscriber:Update: {Name}: notify with context: {context} ");
	}


}
