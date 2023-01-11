namespace BehavioralDesignPattern_State.Abstractions;
internal abstract class State
{
	protected StateContext stateContext;

	protected State(StateContext stateContext)
	{
		this.stateContext = stateContext;
	}

	public abstract void InsertCard();
	public abstract void EjectCard();
	public abstract void InsertPin(int pin);
	public abstract void WithdrawCash(int amount);
}
