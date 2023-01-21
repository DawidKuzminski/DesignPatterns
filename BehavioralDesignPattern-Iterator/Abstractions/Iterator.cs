using System.Collections;

namespace BehavioralDesignPattern_Iterator.Abstractions;
internal abstract class Iterator : IEnumerator
{
	public abstract int Key();

	public object Current => GetCurrent();

	public abstract bool MoveNext();

	public abstract void Reset();

	protected abstract object GetCurrent();
}
