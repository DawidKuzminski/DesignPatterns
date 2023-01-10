using StructuralDesignPattern_Adapter.Abstraction;

namespace StructuralDesignPattern_Adapter.InternalObjects;
internal class WordFileGenerator : IFileGenerator
{
	public string GenerateFile(string fileName, string body, string fileExtension)
	{
		return $"Word file: {fileName} {body} {fileExtension} generated.";
	}
}
