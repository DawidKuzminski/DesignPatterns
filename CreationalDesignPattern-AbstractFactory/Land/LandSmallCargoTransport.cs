using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Land;
internal class LandSmallCargoTransport : ITransport
{
	public string Transport()
	{
		return "Land Small Cargo Transport";
	}
}
