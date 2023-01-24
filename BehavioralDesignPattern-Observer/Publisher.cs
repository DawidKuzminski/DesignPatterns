using BehavioralDesignPattern_Observer.Abstractions;

namespace BehavioralDesignPattern_Observer;
internal class Publisher
{
	private List<ISubscriber> _subscribers = new();

	public void Subscrible(ISubscriber subscriber)
	{
		_subscribers.Add(subscriber);
	}

	public void Unsubscrible(ISubscriber subscriber)
	{
		_subscribers.Remove(subscriber);
	}

	public void Notify(string context)
	{
		foreach (var subscriber in _subscribers)
		{
			subscriber.Update(context);
		}
	}
}
