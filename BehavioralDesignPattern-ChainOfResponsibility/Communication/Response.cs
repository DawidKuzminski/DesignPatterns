namespace BehavioralDesignPattern_ChainOfResponsibility.Communication;
internal class Response
{
	public bool IsSuccess { get; set; }
	public string Message { get; set; }
	public object Data { get; set; }
}
