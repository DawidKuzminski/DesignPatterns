// See https://aka.ms/new-console-template for more information
using BehavioralDesignPattern_State;

Console.WriteLine("Behavioral Design Pattern - State");

var context = new StateContext();
context.EjectCard();
context.InsertCard();
context.InsertPin(2222);
context.InsertPin(1111);
context.WithdrawCash(2000);

context.InsertCard();
context.InsertPin(1111);
context.WithdrawCash(2000);
context.EjectCard();