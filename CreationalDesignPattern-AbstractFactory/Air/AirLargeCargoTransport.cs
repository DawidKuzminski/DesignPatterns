using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Air;
internal class AirLargeCargoTransport : ITransport
{
	public string Transport()
	{
		return "Air Large Cargo Transport";
	}
}
