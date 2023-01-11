using BehavioralDesignPattern_Mediator.Abstractions;

namespace BehavioralDesignPattern_Mediator;
internal class Button : Component
{
	public void Render()
	{
		Console.WriteLine("Button: Render");
	}

	public void Click()
	{
		Console.WriteLine("Button: Click");
		_mediator.Notify(this, "onClick");
	}
}
