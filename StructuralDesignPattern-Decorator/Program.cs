// See https://aka.ms/new-console-template for more information
using StructuralDesignPattern_Decorator;

Console.WriteLine("Hello, World!");

var emailNotification = new EmailNotification();
Console.WriteLine(emailNotification.Send());
Console.WriteLine();

var smsNotification = new SMSNotificationDecorator(emailNotification);
Console.WriteLine(smsNotification.Send());
Console.WriteLine();

var slackNotification = new SlackNotificationDecorator(smsNotification);
Console.WriteLine(slackNotification.Send());
Console.WriteLine();