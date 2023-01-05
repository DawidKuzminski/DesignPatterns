using CreationalDesignPattern_Builder.Abstractions;
using CreationalDesignPattern_Builder.Models;

namespace CreationalDesignPattern_Builder.Builders;
internal class CarManualBuilder : IBuilder
{
	private CarManual _carManual;

	public CarManualBuilder()
	{
		_carManual = new CarManual();
	}

	public void SetEngine()
	{
		_carManual.EngineDescritpion = "Description of 5.0 engine";
	}

	public void SetModel()
	{
		_carManual.ModelManual = "Manual about model";
	}

	public void SetType()
	{
		_carManual.TypeManual = "Manual about type";
	}

	public void SetVersion()
	{
		_carManual.VersionManual = "Manual about version";
	}

	public CarManual Build()
	{
		return _carManual;
	}
}
