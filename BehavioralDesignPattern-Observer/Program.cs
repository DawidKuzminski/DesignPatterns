using BehavioralDesignPattern_Observer;

Console.WriteLine("Behavioral Design Pattern - Observer");

var subscriberOne = new Subscriber("SubscriberOne");
var subscriberTwo = new Subscriber("SubscriberTwo");

var publisher = new Publisher();
publisher.Subscrible(subscriberOne);
publisher.Subscrible(subscriberTwo);

publisher.Notify("SAO!");

publisher.Unsubscrible(subscriberTwo);
publisher.Notify("This is SWORDLAND!");