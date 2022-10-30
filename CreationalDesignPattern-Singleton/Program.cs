// See https://aka.ms/new-console-template for more information
using CreationalDesignPattern_Singleton;

Console.WriteLine("Creational Design Pattern: Singleton!");

var config = Configuration.Instance;
Console.WriteLine($"Created instance value: {config.InitValue}");

config.InitValue = "Created instance value after changed";
Console.WriteLine(config.InitValue);

var config2 = Configuration.Instance;
Console.WriteLine($"Another instace value after init: {config.InitValue}");

Console.ReadKey();



