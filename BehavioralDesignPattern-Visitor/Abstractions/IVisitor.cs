using BehavioralDesignPattern_Visitor.Components;

namespace BehavioralDesignPattern_Visitor.Abstractions;
internal interface IVisitor
{
	void VisitCity(CityPolicyComponent visitor);
	void VisitIndustry(IndustryPolicyComponent visitor);
}
