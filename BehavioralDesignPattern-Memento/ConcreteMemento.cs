using BehavioralDesignPattern_Memento.Abstractions;

namespace BehavioralDesignPattern_Memento;
internal class ConcreteMemento : IMemento
{
	private string _state;
	private DateTime _date;

	public ConcreteMemento(string state)
	{
		_state = state;
		_date = DateTime.Now;
	}

	public DateTime GetDateTime()
	{
		return _date;
	}

	public string GetName()
	{
		return $"{_date} / ({_state.Substring(0, 9)})...";
	}

	public string GetState()
	{
		return _state;
	}
}
