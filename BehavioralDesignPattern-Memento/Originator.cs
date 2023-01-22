using BehavioralDesignPattern_Memento.Abstractions;

namespace BehavioralDesignPattern_Memento;
internal class Originator
{
	private string _state;
	private readonly string _allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

	public Originator(string state)
	{
		_state = state;
		Console.WriteLine($"Originator: My init state is: {_state}");
	}

	public void DoSomething()
	{
		Console.WriteLine("Originator:DoSomething");
		_state = GenerateRandomString(30);
		Console.WriteLine($"Originator:DoSomething: New state: {_state}");
	}

	public IMemento Save()
	{
		return new ConcreteMemento(_state);
	}

	public void Restore(IMemento memento)
	{
		if(memento is not ConcreteMemento)
		{
			throw new Exception("Unknown memento class! " + memento.ToString());
		}

		_state = memento.GetState();
		Console.WriteLine($"Originator:Restore: restored state: {_state}");
	}

	private string GenerateRandomString(int length = 10)
	{
		var result = string.Empty;

		for (int index = 0; index < length; index++)
		{
			result += _allowedSymbols[new Random().Next(0, _allowedSymbols.Length)];
			Thread.Sleep(10);
		}

		return result;
	}
}
