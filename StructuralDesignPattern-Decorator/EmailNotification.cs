using StructuralDesignPattern_Decorator.Abstraction;

namespace StructuralDesignPattern_Decorator;
internal class EmailNotification : INotification
{
	public string Send()
	{
		return "Email notification send";
	}
}
