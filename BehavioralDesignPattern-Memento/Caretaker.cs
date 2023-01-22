using BehavioralDesignPattern_Memento.Abstractions;

namespace BehavioralDesignPattern_Memento;
internal class Caretaker
{
	private List<IMemento> _mementos = new List<IMemento>();
	private Originator _originator;

	public Caretaker(Originator originator)
	{
		_originator = originator;
	}

	public void Backup()
	{
		Console.WriteLine("Caretaker: Saving Originator's state. . .");
		_mementos.Add(_originator.Save());
	}

	public void Undo()
	{
		if (_mementos.Count == 0)
			return;

		var memento = _mementos.Last();
		_mementos.Remove(memento);

		Console.WriteLine($"Caretaker:Undo: Restoring state: {memento.GetName()}");
		try
		{
			_originator.Restore(memento);
		}
		catch (Exception)
		{
			this.Undo();
		}
	}

	public void ShowHistory()
	{
		Console.WriteLine("Caretaker:ShowHistory: History of mementos:");
		foreach (var item in _mementos)
		{
			Console.WriteLine(item.GetName());
		}
	}
}
