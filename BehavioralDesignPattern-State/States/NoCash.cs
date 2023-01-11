using BehavioralDesignPattern_State.Abstractions;

namespace BehavioralDesignPattern_State.States;
internal class NoCash : State
{
	public NoCash(StateContext stateContext) : base(stateContext)
	{
	}

	public override void InsertCard()
	{
		Console.WriteLine("NoCash: Sorry, you are out of cash");
	}

	public override void EjectCard()
	{
		Console.WriteLine("NoCash: Sorry, you are out of cash");
	}

	public override void InsertPin(int pin)
	{
		Console.WriteLine("NoCash: Sorry, you are out of cash");
	}

	public override void WithdrawCash(int amount)
	{
		Console.WriteLine("NoCash: Sorry, you are out of cash");
	}
}
