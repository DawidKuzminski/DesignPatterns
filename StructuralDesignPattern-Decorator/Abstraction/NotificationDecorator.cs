namespace StructuralDesignPattern_Decorator.Abstraction;
internal abstract class NotificationDecorator : INotification
{
    private readonly INotification _notification;

    public NotificationDecorator(INotification notification)
    {
        _notification = notification;
    }

    public virtual string Send()
    {
        return _notification.Send();
    }
}
