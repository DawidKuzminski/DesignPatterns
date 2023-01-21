using BehavioralDesignPattern_Iterator.Abstractions;

namespace BehavioralDesignPattern_Iterator.Iterators;
internal class AlphabeticalOrderIterator : Iterator
{
	private readonly WordsCollection _collection;

	private int _position = -1;
	private bool _reverse = false;

	public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
	{
		_collection = collection;
		_reverse = reverse;

		if(_reverse)
		{
			_position = _collection.GetItems().Count;
		}
	}

	public override int Key()
	{
		return _position;
	}

	public override bool MoveNext()
	{
		var newPosition = this._position + (_reverse ? -1 : 1);
		if(newPosition >= 0 && newPosition < _collection.GetItems().Count)
		{
			_position = newPosition;
			return true;
		}

		return false;
	}

	public override void Reset()
	{
		_position = _reverse ? _collection.GetItems().Count - 1 : 0;
	}

	protected override object GetCurrent()
	{
		return _collection.GetItems()[_position];
	}
}
