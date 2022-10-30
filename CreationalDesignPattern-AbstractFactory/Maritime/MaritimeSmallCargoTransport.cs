using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Maritime;
internal class MaritimeSmallCargoTransport : ITransport
{
	public string Transport()
	{
		return "Maritime Small Cargo Transport";
	}
}
