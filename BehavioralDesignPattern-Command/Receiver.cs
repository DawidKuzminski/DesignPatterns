namespace BehavioralDesignPattern_Command;

internal class Receiver
{
	public void DoSomething(string operation)
	{
		Console.WriteLine($"Receiver:DoSomething: Working on: {operation}");
	}

	public void DoSomethingElse(string operation)
	{
		Console.WriteLine($"Receiver:DoSomethingElse: Working on {operation}");
	}
}