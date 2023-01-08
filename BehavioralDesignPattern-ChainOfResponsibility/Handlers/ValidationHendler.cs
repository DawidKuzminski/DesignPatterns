using BehavioralDesignPattern_ChainOfResponsibility.Abstraction;

namespace BehavioralDesignPattern_ChainOfResponsibility.Handlers;
internal class ValidationHendler : HandlerBase
{
	public ValidationHendler(IHandler next) : base(next)
	{ }

	public override void Handle(RequestContext requestContext)
	{
		if(requestContext.Request.EntityId > 100)
		{
			_next.Handle(requestContext);
			return;
		}

		requestContext.Response.IsSuccess = false;
		requestContext.Response.Message = "Validation error: Entity Id must be greater than 100";
	}
}
