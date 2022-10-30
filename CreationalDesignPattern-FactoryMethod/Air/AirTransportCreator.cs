using CreationalDesignPattern_FactoryMethod.Abstraction;

namespace CreationalDesignPattern_FactoryMethod.Air;

internal class AirTransportCreator : Creator
{
	public override ITransport FactoryMethod()
	{
		return new AirTransport();
	}
}
