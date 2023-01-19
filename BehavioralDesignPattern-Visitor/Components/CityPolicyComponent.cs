using BehavioralDesignPattern_Visitor.Abstractions;

namespace BehavioralDesignPattern_Visitor.Components;
internal class CityPolicyComponent : IComponent
{
	public void Accept(IVisitor visitor)
	{
		visitor.VisitCity(this);
	}

	public string CalculatePolicyForCity() => "Calculate Policy for City";
}
