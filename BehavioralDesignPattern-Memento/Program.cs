using BehavioralDesignPattern_Memento;

Console.WriteLine("Behavioral Design Pattern - Memento");

var originator = new Originator("Super-duper-super-puper-super.");
var caretaker = new Caretaker(originator);

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("Client: Now, let's rollback!");
caretaker.Undo();

Console.WriteLine("Client: Once more!");
caretaker.Undo();

Console.WriteLine();