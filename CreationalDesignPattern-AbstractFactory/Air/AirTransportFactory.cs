using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Air;
internal class AirTransportFactory : IAbstractFactory
{
	public ITransport CreateBigCargo()
	{
		return new AirLargeCargoTransport();
	}

	public ITransport CreateMediumCargo()
	{
		return new AirMediumCargoTransport();
	}

	public ITransport CreateSmallCargo()
	{
		return new AirSmallCargoTransport();
	}
}
