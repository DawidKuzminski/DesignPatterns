namespace BehavioralDesignPattern_TemplateMethod.Abstractions;
public abstract class Generator
{
	protected virtual void GetData()
	{
		Console.WriteLine("Generator: GetData");
	}

	protected abstract void PrepareData();

	protected abstract void GenerateFile();

	protected void SendFile()
	{
		Console.WriteLine("Generator: SendFile");
	}

	public void GenerateReport()
	{
		GetData();
		PrepareData();
		GenerateFile();
		SendFile();
	}
}
