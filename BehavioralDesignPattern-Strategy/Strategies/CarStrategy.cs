using BehavioralDesignPattern_Strategy.Abstractions;

namespace BehavioralDesignPattern_Strategy.Strategies;
internal class CarStrategy : IRouteStrategy
{
	public void CalculateRoute(Coordinate start, Coordinate target)
	{
		Console.WriteLine("Strategy: Car");
	}
}
