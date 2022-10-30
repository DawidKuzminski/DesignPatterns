using CreationalDesignPattern_FactoryMethod.Abstraction;

namespace CreationalDesignPattern_FactoryMethod.Maritime
{
	internal class MaritimeTransportCreator : Creator
	{
		public override ITransport FactoryMethod()
		{
			return new MaritimeTransport();
		}
	}
}
