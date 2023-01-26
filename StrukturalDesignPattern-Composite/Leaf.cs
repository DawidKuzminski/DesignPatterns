namespace StrukturalDesignPattern_Composite;
internal class Leaf : Component
{
	public override string Operation()
	{
		return "Leaf";
	}

	public override bool IsComposite()
	{
		return false;
	}
}
