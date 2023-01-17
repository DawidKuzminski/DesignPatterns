using BehavioralDesignPattern_TemplateMethod.Abstractions;

namespace BehavioralDesignPattern_TemplateMethod;
internal class ExcelGenerator : Generator
{
	protected override void GenerateFile()
	{
		Console.WriteLine("ExcelGenerator: GenerateFile");
	}

	protected override void PrepareData()
	{
		Console.WriteLine("ExcelGenerator: PrepareData");
	}
}
