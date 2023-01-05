using CreationalDesignPattern_Builder.Abstractions;

namespace CreationalDesignPattern_Builder;
internal class Director
{
	private IBuilder _builder;

	public IBuilder Builder { set { _builder = value; } }

	public void BuildMinimalProduct()
	{
		_builder.SetEngine();
	}

	public void BuildFullProduct()
	{
		_builder.SetEngine();
		_builder.SetType();
		_builder.SetModel();
		_builder.SetVersion();
	}
}
