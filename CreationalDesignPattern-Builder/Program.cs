// See https://aka.ms/new-console-template for more information
using CreationalDesignPattern_Builder;
using CreationalDesignPattern_Builder.Builders;

Console.WriteLine("Hello, World!");

var director = new Director();
var carBuilder = new CarBuilder();
director.Builder = carBuilder;
var carManualBuilder = new CarManualBuilder();

Console.WriteLine("Car from director");
director.BuildMinimalProduct();
var car = carBuilder.Build();

Console.WriteLine(car.EngineType);
Console.WriteLine(car.Type);
Console.WriteLine(car.Model);
Console.WriteLine(car.Version);

Console.WriteLine("Car manual from builder");
carManualBuilder.SetEngine();
carManualBuilder.SetVersion();
var carManual = carManualBuilder.Build();

Console.WriteLine(carManual.EngineDescritpion);
Console.WriteLine(carManual.TypeManual);
Console.WriteLine(carManual.ModelManual);
Console.WriteLine(carManual.VersionManual);

Console.ReadKey();

