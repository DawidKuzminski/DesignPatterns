namespace BehavioralDesignPattern_Mediator.Abstractions;

public interface IMediator
{
	public void Notify(Component component, string ev);
}