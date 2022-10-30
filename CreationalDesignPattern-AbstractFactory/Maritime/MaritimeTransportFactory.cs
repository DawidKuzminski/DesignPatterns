using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Maritime;
internal class MaritimeTransportFactory : IAbstractFactory
{
	public ITransport CreateBigCargo()
	{
		return new MaritimeLargeCargoTransport();
	}

	public ITransport CreateMediumCargo()
	{
		return new MaritimeMediumCargoTransport();
	}

	public ITransport CreateSmallCargo()
	{
		return new MaritimeSmallCargoTransport();
	}
}
