using BehavioralDesignPattern_Strategy.Abstractions;

namespace BehavioralDesignPattern_Strategy.Strategies;
internal class WalkStrategy : IRouteStrategy
{
	public void CalculateRoute(Coordinate start, Coordinate target)
	{
		Console.WriteLine("Strategy: Walk");
	}
}
