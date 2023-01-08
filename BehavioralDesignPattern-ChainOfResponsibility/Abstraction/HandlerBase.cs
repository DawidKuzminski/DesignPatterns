namespace BehavioralDesignPattern_ChainOfResponsibility.Abstraction;
internal abstract class HandlerBase : IHandler
{
	protected readonly IHandler _next;

	protected HandlerBase(IHandler handler)
	{
		_next = handler;
	}

	public abstract void Handle(RequestContext requestContext);
}
