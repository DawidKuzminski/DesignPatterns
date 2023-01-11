using BehavioralDesignPattern_State.Abstractions;

namespace BehavioralDesignPattern_State.States;
internal class NoCard : State
{
    public NoCard(StateContext stateContext) : base(stateContext)
    {
    }

    public override void InsertCard()
    {
        Console.WriteLine("NoCard: Card inserted");
		stateContext.ChangeState(new CardInserted(stateContext));
	}

    public override void EjectCard()
    {
        Console.WriteLine("NoCard: No card inserted yet");

    }

    public override void InsertPin(int pin)
    {
        Console.WriteLine("NoCard: No card inserted yet");
    }

    public override void WithdrawCash(int amount)
    {
        Console.WriteLine("NoCard: No card inserted yet");
    }
}
