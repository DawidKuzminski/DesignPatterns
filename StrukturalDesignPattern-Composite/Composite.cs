namespace StrukturalDesignPattern_Composite;
internal class Composite : Component
{
	protected List<Component> _children = new List<Component>();

	public override string Operation()
	{
		int i = 0;
		string result = "Branch(";

		foreach (var item in _children)
		{
			result += item.Operation();
			if(i != _children.Count - 1)
			{
				result += "+";
			}

			i++;
		}

		return result + ")";
	}

	public override void Add(Component component)
	{
		_children.Add(component);
	}

	public override void Remove(Component component)
	{
		_children.Remove(component);
	}
}
