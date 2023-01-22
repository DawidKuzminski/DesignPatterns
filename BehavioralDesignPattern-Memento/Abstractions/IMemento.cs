
namespace BehavioralDesignPattern_Memento.Abstractions;
internal interface IMemento
{
	string GetName();
	string GetState();
	DateTime GetDateTime();
}
