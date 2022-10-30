using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Air;
internal class AirMediumCargoTransport : ITransport
{
	public string Transport()
	{
		return "Air Medium Cargo Transport";
	}
}
