using BehavioralDesignPattern_TemplateMethod.Abstractions;

namespace BehavioralDesignPattern_TemplateMethod;
internal class PDFGenerator : Generator
{
	protected override void GenerateFile()
	{
		Console.WriteLine("PDFGenerator: GenerateFile");
	}

	protected override void PrepareData()
	{
		Console.WriteLine("PDFGenerator: PrepareData");
	}

	protected override void GetData()
	{
		Console.WriteLine("PDFGenerator: GetData");
	}
}
