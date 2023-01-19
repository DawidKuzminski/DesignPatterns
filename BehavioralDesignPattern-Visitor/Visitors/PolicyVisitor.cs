using BehavioralDesignPattern_Visitor.Abstractions;
using BehavioralDesignPattern_Visitor.Components;

namespace BehavioralDesignPattern_Visitor.Visitors;
internal class PolicyVisitor : IVisitor
{
	public void VisitCity(CityPolicyComponent visitor)
	{
		Console.WriteLine($"Visitor: {visitor.CalculatePolicyForCity()}");
	}

	public void VisitIndustry(IndustryPolicyComponent visitor)
	{
		Console.WriteLine($"Visitor: {visitor.CalculatePolicyForIndustry()}");
	}
}
