using CreationalDesignPattern_Builder.Abstractions;
using CreationalDesignPattern_Builder.Models;

namespace CreationalDesignPattern_Builder.Builders;
internal class CarBuilder : IBuilder
{
	private Car _car;

	public CarBuilder()
	{
		_car = new Car();
	}

	public void SetEngine()
	{
		_car.EngineType = "5.0";
	}

	public void SetModel()
	{
		_car.Model = "Mustang";
	}

	public void SetType()
	{
		_car.Type = "Fastback";
	}

	public void SetVersion()
	{
		_car.Version = "BOSS 429";
	}

	public Car Build()
	{
		return _car;
	}
}
