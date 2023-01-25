using Newtonsoft.Json;

namespace StructuralDesignPattern_Flyweight;
internal class Flyweight
{
	private readonly Car _sharedState;

	public Flyweight(Car car)
	{
		_sharedState = car;
	}

	public void Operation(Car uniqueState)
	{
		string sharedStateJson = JsonConvert.SerializeObject(_sharedState);
		string uniqueStateJson = JsonConvert.SerializeObject(uniqueState);
		Console.WriteLine($"Flyweight:Operation: Displaying shared {sharedStateJson} and unique {uniqueStateJson} state.");
	}
}
