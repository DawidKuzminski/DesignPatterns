using BehavioralDesignPattern_Iterator;

Console.WriteLine("Behavioral Design Pattern - Iterator");

var collection = new WordsCollection();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

Console.WriteLine("Straight traversal:");
foreach (var item in collection)
{
	Console.WriteLine(item);
}

Console.WriteLine("---------------------------------");
Console.WriteLine("Reverse traversal:");
collection.ReverseDirection();
foreach (var item in collection)
{
	Console.WriteLine(item);
}