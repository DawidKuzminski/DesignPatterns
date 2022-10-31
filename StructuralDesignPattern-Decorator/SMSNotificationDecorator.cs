using StructuralDesignPattern_Decorator.Abstraction;

namespace StructuralDesignPattern_Decorator;
internal class SMSNotificationDecorator : NotificationDecorator
{
	public SMSNotificationDecorator(INotification notification) : base(notification)
	{ }

	public override string Send()
	{
		return $"SMS notification send; {base.Send()}";
	}
}
