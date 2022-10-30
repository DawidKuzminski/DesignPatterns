using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Maritime;
internal class MaritimeMediumCargoTransport : ITransport
{
	public string Transport()
	{
		return "Maritime Medium Cargo Transport";
	}
}
