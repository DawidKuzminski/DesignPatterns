namespace BehavioralDesignPattern_Visitor.Abstractions;
internal interface IComponent
{
	void Accept(IVisitor visitor);
}
