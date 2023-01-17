using BehavioralDesignPattern_TemplateMethod.Abstractions;

namespace BehavioralDesignPattern_TemplateMethod;
internal class CSVGenerator : Generator
{
	protected override void GenerateFile()
	{
		Console.WriteLine("CSVGeneraor: GenerateFile");
	}

	protected override void PrepareData()
	{
		Console.WriteLine("CSVGeneraor: PrepareData");
	}
}
