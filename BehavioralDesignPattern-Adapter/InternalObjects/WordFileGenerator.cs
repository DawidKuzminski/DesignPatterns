using BehavioralDesignPattern_Adapter.Abstraction;

namespace BehavioralDesignPattern_Adapter.InternalObjects;
internal class WordFileGenerator : IFileGenerator
{
	public string GenerateFile(string fileName, string body, string fileExtension)
	{
		return $"Word file: {fileName} {body} {fileExtension} generated.";
	}
}
