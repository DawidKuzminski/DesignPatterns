using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Air;
internal class AirSmallCargoTransport : ITransport
{
	public string Transport()
	{
		return "Air Small Cargo Transport";
	}
}
