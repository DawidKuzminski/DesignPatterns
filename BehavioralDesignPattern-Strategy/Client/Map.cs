using BehavioralDesignPattern_Strategy.Abstractions;

namespace BehavioralDesignPattern_Strategy.Client;
internal class Map
{
	private IRouteStrategy _routeStrategy;

	public Map(IRouteStrategy routeStrategy)
	{
		_routeStrategy = routeStrategy;
	}

	public void CreateRoute(Coordinate start, Coordinate target)
	{
		_routeStrategy.CalculateRoute(start, target);
	}
}
