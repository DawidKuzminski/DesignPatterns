using BehavioralDesignPattern_State.Abstractions;

namespace BehavioralDesignPattern_State.States;
internal class CardInserted : State
{
	public CardInserted(StateContext stateContext) : base(stateContext)
	{
	}

	public override void InsertCard()
	{
		Console.WriteLine("CardInserted: Card already inserted");
	}

	public override void EjectCard()
	{
		Console.WriteLine("CardInserted: Card ejected");
		stateContext.ChangeState(new NoCard(stateContext));
	}

	public override void InsertPin(int pin)
	{
		if(pin == 1111)
		{
			Console.WriteLine("CardInserted: Correct PIN inserted");
			stateContext.ChangeState(new PinInserted(stateContext));
		}
		else
		{
			Console.WriteLine("CardInserted: Incorrect PIN inserted");
			stateContext.ChangeState(new NoCard(stateContext));
		}
	}

	public override void WithdrawCash(int amount)
	{
		Console.WriteLine("CardInserted: Insert PIN first");
	}
}
