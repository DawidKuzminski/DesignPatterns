using StructuralDesignPattern_Adapter.Abstraction;
using StructuralDesignPattern_Adapter.ExternalObjects;

namespace StructuralDesignPattern_Adapter;
internal class PDFGeneratorAdapter : IFileGenerator
{
	public string GenerateFile(string fileName, string body, string fileExtension)
	{
		var pdfGenerator = new PDFGenerator();
		var size = CalculateFileSize(body);

		return pdfGenerator.GeneratePDF(body, fileName, size);
	}

	private string CalculateFileSize(string body)
	{
		return "1234";
	}
}
