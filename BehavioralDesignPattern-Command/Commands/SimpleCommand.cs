
using BehavioralDesignPattern_Command.Abstraction;

namespace BehavioralDesignPattern_Command.Commands;
internal class SimpleCommand : ICommand
{
	private string _payload;

	public SimpleCommand(string payload)
	{
		_payload = payload;
	}

	public void Execute()
	{
		Console.WriteLine($"SimpleCommand {_payload}");
	}
}
