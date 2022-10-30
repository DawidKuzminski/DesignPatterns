namespace CreationalDesignPattern_AbstractFactory.Abstraction;

internal interface IAbstractFactory
{
	ITransport CreateSmallCargo();
	ITransport CreateMediumCargo();
	ITransport CreateBigCargo();
}
