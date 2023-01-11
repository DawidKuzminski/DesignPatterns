using BehavioralDesignPattern_Mediator.Abstractions;

namespace BehavioralDesignPattern_Mediator;
internal class RegisterClientView : IMediator
{
	private Button _submitButton;
	private Checkbox _clientType;

	public RegisterClientView(Button submitButton, Checkbox clientType)
	{
		_submitButton = submitButton;
		_clientType = clientType;

		_submitButton.SetMediator(this);
		_clientType.SetMediator(this);
	}

	public void Notify(Component component, string ev)
	{
		if(ev.Equals("onClick"))
		{
			_submitButton.Render();
		}
		else if(ev.Equals("selected"))
		{
			_clientType.Save();
		}
	}
}
