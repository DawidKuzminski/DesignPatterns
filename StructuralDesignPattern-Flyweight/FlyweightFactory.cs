namespace StructuralDesignPattern_Flyweight;
internal class FlyweightFactory
{
	private List<Tuple<Flyweight, string>> _flyweights = new();

	public FlyweightFactory(params Car[] args)
	{
		foreach (var item in args)
		{
			_flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(item), GetKey(item)));
		}
	}

	public string GetKey(Car key)
	{
		var elements = new List<string>();
		elements.Add(key.Model);
		elements.Add(key.Color);
		elements.Add(key.Company);

		if(key.Owner is not null && key.Number is not null)
		{
			elements.Add(key.Number);
			elements.Add(key.Owner);
		}

		elements.Sort();

		return string.Join("_", elements);
	}

	public Flyweight GetFlyweight(Car sharedState)
	{
		string key = GetKey(sharedState);
		if(_flyweights.Where(x => x.Item2 == key).Count() == 0)
		{
			Console.WriteLine("FlyweightFactory:GetFlyweight: Can't find a flyweight, creating new one.");
			_flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), GetKey(sharedState)));
		}
		else
		{
			Console.WriteLine("FlyweightFactory:GetFlyweight: Reusing existing flyweight.");
		}

		return _flyweights.Where(x => x.Item2 == key).FirstOrDefault().Item1;
	}

	public void ListFlyweights()
	{
		var count = _flyweights.Count();
		Console.WriteLine($"FlyweightFactory:ListFlyweights: I have {count} flyweights:");

		foreach (var item in _flyweights)
		{
			Console.WriteLine(item.Item2);
		}
	}
}
