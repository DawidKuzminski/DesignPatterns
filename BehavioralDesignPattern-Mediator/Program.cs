using BehavioralDesignPattern_Mediator;

Console.WriteLine("Behavioral Design Pattern - Mediator");

var button = new Button();
var checkbox = new Checkbox();

new RegisterClientView(button, checkbox);

button.Click();
checkbox.Select();
