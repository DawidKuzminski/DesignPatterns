using CreationalDesignPattern_FactoryMethod.Abstraction;
using CreationalDesignPattern_FactoryMethod.Air;
using CreationalDesignPattern_FactoryMethod.Land;
using CreationalDesignPattern_FactoryMethod.Maritime;

namespace CreationalDesignPattern_FactoryMethod;

internal class Client
{
	public void Main()
	{
		Console.WriteLine("App: Launched with the LandTransportCreator.");
		ClientCode(new LandTransportCreator());

		Console.WriteLine("");

		Console.WriteLine("App: Launched with the AirTransportCreator.");
		ClientCode(new AirTransportCreator());

		Console.WriteLine("");

		Console.WriteLine("App: Launched with the MaritimeTransportCreator.");
		ClientCode(new MaritimeTransportCreator());
	}

	public void ClientCode(Creator creator)
	{
		Console.WriteLine("Client: I'm not aware of the creator's class," +
			"but it still works.\n" + creator.CreateTransport());
	}
}
