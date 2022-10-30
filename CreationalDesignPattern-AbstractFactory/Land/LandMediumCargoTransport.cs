using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Land;
internal class LandMediumCargoTransport : ITransport
{
	public string Transport()
	{
		return "Land Medium Cargo Transport";
	}
}
