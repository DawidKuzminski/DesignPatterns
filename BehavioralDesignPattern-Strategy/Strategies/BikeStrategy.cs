using BehavioralDesignPattern_Strategy.Abstractions;

namespace BehavioralDesignPattern_Strategy.Strategies;
internal class BikeStrategy : IRouteStrategy
{
	public void CalculateRoute(Coordinate start, Coordinate target)
	{
		Console.WriteLine("Strategy: Bike");
	}
}
