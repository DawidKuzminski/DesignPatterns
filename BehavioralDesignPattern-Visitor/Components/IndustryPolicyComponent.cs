using BehavioralDesignPattern_Visitor.Abstractions;

namespace BehavioralDesignPattern_Visitor.Components;
internal class IndustryPolicyComponent : IComponent
{
	public void Accept(IVisitor visitor)
	{
		visitor.VisitIndustry(this);
	}

	public string CalculatePolicyForIndustry() => "Calculate Policy for Industry";
}
