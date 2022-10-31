// See https://aka.ms/new-console-template for more information
using StructuralDesignPattern_Decorator;

Console.WriteLine("Hello, World!");

var emailNotification = new EmailNotification();
Console.WriteLine(emailNotification.Send());
Console.WriteLine();

var smsAndEmailNotification = new SMSNotificationDecorator(emailNotification);
Console.WriteLine(smsAndEmailNotification.Send());