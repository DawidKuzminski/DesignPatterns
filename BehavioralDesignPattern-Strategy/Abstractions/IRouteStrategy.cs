namespace BehavioralDesignPattern_Strategy.Abstractions;
public interface IRouteStrategy
{
	public void CalculateRoute(Coordinate start, Coordinate target);
}
