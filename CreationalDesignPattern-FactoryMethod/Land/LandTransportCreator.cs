using CreationalDesignPattern_FactoryMethod.Abstraction;

namespace CreationalDesignPattern_FactoryMethod.Land;

internal class LandTransportCreator : Creator
{
	public override ITransport FactoryMethod()
	{
		return new LandTransport();
	}
}
