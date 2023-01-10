using StructuralDesignPattern_Adapter.Abstraction;

namespace StructuralDesignPattern_Adapter.InternalObjects;
internal class ExcelFileGenerator : IFileGenerator
{
	public string GenerateFile(string fileName, string body, string fileExtension)
	{
		return $"Excel file: {fileName} {body} {fileExtension} generated.";
	}
}
