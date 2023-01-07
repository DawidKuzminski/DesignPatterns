using BehavioralDesignPattern_Command.Abstraction;

namespace BehavioralDesignPattern_Command.Commands;
internal class ComplexCommand : ICommand
{
	private Receiver _receiver;
	private string _firstOperationName;
	private string _secondOperationName;

	public ComplexCommand(Receiver receiver, string firstOperationName, string secondOperationName)
	{
		_receiver = receiver;
		_firstOperationName = firstOperationName;
		_secondOperationName = secondOperationName;
	}
	public void Execute()
	{
		Console.WriteLine($"ComplexCommand working on. . .");
		_receiver.DoSomething(_firstOperationName);
		_receiver.DoSomethingElse(_secondOperationName);
	}
}
