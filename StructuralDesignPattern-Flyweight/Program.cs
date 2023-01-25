using StructuralDesignPattern_Flyweight;
using System.Runtime.CompilerServices;

Console.WriteLine("Structural Design Pattern: Flyweight");

var factory = new FlyweightFactory(
				new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
				new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
				new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
				new Car { Company = "BMW", Model = "M5", Color = "red" },
				new Car { Company = "BMW", Model = "X6", Color = "white" }
			);

factory.ListFlyweights();

RegisterCar(factory, new Car
{
	Number = "CL234IR",
	Owner = "James Doe",
	Company = "BMW",
	Model = "M5",
	Color = "red"
});

RegisterCar(factory, new Car
{
	Number = "CL234IR",
	Owner = "James Doe",
	Company = "BMW",
	Model = "X1",
	Color = "red"
});

factory.ListFlyweights();

static void RegisterCar(FlyweightFactory factory, Car car)
{
	Console.WriteLine("Client: Adding a car to database");
	var flyweight = factory.GetFlyweight(new Car
	{
		Color = car.Color,
		Model = car.Model,
		Company = car.Company
	});

	flyweight.Operation(car);
}
