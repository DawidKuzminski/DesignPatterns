using BehavioralDesignPattern_ChainOfResponsibility.Communication;

namespace BehavioralDesignPattern_ChainOfResponsibility;
internal class RequestContext
{
	public Request Request { get; set; }
	public Response Response { get; set; }
}
