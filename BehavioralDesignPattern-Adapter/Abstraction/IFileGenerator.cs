namespace StructuralDesignPattern_Adapter.Abstraction;
public interface IFileGenerator
{
	string GenerateFile(string fileName, string body, string fileExtension);
}
