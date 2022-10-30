using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Maritime;
internal class MaritimeLargeCargoTransport : ITransport
{
	public string Transport()
	{
		return "Maritime Large Cargo Transport";
	}
}
