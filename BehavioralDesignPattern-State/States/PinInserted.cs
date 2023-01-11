using BehavioralDesignPattern_State.Abstractions;

namespace BehavioralDesignPattern_State.States;
internal class PinInserted : State
{
	public PinInserted(StateContext stateContext) : base(stateContext)
	{
	}

	public override void InsertCard()
	{
		Console.WriteLine("PinInserted: Card already inserted");
	}

	public override void EjectCard()
	{
		Console.WriteLine("PinInserted: Card ejected");
		stateContext.ChangeState(new NoCard(stateContext));
	}

	public override void InsertPin(int pin)
	{
		Console.WriteLine("PinInserted: Correct PIN code provided");
	}

	public override void WithdrawCash(int amount)
	{
		if(amount > stateContext.AvailableCash)
		{
			Console.WriteLine("PinInserted: That amount of cash is not available");
		}
		else
		{
			Console.WriteLine($"PinInserted: You have withdraw {amount} from the machine");
			stateContext.AvailableCash -= amount;

			if(stateContext.AvailableCash == 0)
			{
				stateContext.ChangeState(new NoCash(stateContext));
			}
			else
			{
				Console.WriteLine("PinInserted: Card ejected");
				stateContext.ChangeState(new NoCard(stateContext));
			}
		}
	}
}
