using BehavioralDesignPattern_ChainOfResponsibility.Abstraction;

namespace BehavioralDesignPattern_ChainOfResponsibility.Handlers;
internal class ResultHandler : HandlerBase
{
	public ResultHandler(IHandler next) : base(next)
	{ }

	public override void Handle(RequestContext requestContext)
	{
		requestContext.Response.IsSuccess = true;
		requestContext.Response.Data = "SomeValue";
	}
}
