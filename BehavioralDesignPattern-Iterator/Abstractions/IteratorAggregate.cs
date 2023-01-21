using System.Collections;

namespace BehavioralDesignPattern_Iterator.Abstractions;
internal abstract class IteratorAggregate : IEnumerable
{
	public abstract IEnumerator GetEnumerator();
}
