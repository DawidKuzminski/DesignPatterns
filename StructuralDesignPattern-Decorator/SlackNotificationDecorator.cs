using StructuralDesignPattern_Decorator.Abstraction;

namespace StructuralDesignPattern_Decorator;
internal class SlackNotificationDecorator : NotificationDecorator
{
	public SlackNotificationDecorator(INotification notification) : base(notification)
	{
	}

	public override string Send()
	{
		return $"Slack notification send; {base.Send()}";
	}
}
