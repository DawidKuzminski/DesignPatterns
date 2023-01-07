using BehavioralDesignPattern_Command;
using BehavioralDesignPattern_Command.Commands;

Console.WriteLine("Behavioral Design Pattern - Command");

var invoker = new Invoker();
invoker.SetOnStart(new SimpleCommand("InitApp Command"));

var receiver = new Receiver();
invoker.SetOnFinish(new ComplexCommand(receiver, "SendEmail Command", "SaveData Command"));
invoker.Execute();