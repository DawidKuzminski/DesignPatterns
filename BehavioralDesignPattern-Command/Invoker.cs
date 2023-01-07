using BehavioralDesignPattern_Command.Abstraction;

namespace BehavioralDesignPattern_Command;
internal class Invoker
{
	private ICommand _commandOnStart;
	private ICommand _commadOnFinish;

	public void SetOnStart(ICommand command)
	{
		_commandOnStart = command;
	}

	public void SetOnFinish(ICommand command)
	{
		_commadOnFinish = command;
	}

	public void Execute()
	{
		Console.WriteLine("Invoker on start . . .");
		_commandOnStart.Execute();

		Console.WriteLine("Invoker on finish . . .");
		_commadOnFinish.Execute();
	}
}
