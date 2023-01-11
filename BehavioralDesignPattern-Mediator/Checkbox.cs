using BehavioralDesignPattern_Mediator.Abstractions;

namespace BehavioralDesignPattern_Mediator;
internal class Checkbox : Component
{
	public void Select()
	{
		Console.WriteLine("Checkbox: Selected");
		_mediator.Notify(this, "selected");
	}

	public void Save()
	{
		Console.WriteLine("Checkbox: Save");
	}
}
