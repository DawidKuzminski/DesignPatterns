using CreationalDesignPattern_AbstractFactory.Abstraction;
using CreationalDesignPattern_AbstractFactory.Air;
using CreationalDesignPattern_AbstractFactory.Land;
using CreationalDesignPattern_AbstractFactory.Maritime;

namespace CreationalDesignPattern_AbstractFactory;
internal class Client
{
	public void Main()
	{
		Console.WriteLine("Client select LAND transport");
		ClienMethod(new LandTransportFactory());
		Console.WriteLine();

		Console.WriteLine("Client select AIR transport");
		ClienMethod(new AirTransportFactory());
		Console.WriteLine();

		Console.WriteLine("Client select MARITIME transport");
		ClienMethod(new MaritimeTransportFactory());
		Console.WriteLine();

	}

	public void ClienMethod(IAbstractFactory abstractFactory)
	{
		var smallCargo = abstractFactory.CreateSmallCargo();
		var mediumCargo = abstractFactory.CreateMediumCargo();
		var largeCargo = abstractFactory.CreateBigCargo();

		Console.WriteLine("Selected small cargo option: " + smallCargo.Transport());
		Console.WriteLine("Selected medium cargo option: " + mediumCargo.Transport());
		Console.WriteLine("Selected large cargo option: " + largeCargo.Transport());
	}
}
