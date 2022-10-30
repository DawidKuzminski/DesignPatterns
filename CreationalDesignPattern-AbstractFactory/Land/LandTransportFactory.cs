using CreationalDesignPattern_AbstractFactory.Abstraction;

namespace CreationalDesignPattern_AbstractFactory.Land
{
	internal class LandTransportFactory : IAbstractFactory
	{
		public ITransport CreateBigCargo()
		{
			return new LandSmallCargoTransport();
		}

		public ITransport CreateMediumCargo()
		{
			return new LandMediumCargoTransport();
		}

		public ITransport CreateSmallCargo()
		{
			return new LandSmallCargoTransport();
		}
	}
}
