namespace BehavioralDesignPattern_ChainOfResponsibility.Abstraction;
internal interface IHandler
{
	void Handle(RequestContext requestContext);
}
