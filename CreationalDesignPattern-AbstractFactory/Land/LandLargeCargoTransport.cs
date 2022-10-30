using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Land;
internal class LandLargeCargoTransport : ITransport
{
	public string Transport()
	{
		return "Land Large Cargo Transport";
	}
}
