namespace StructuralDesignPattern_Adapter.ExternalObjects;
public class PDFGenerator
{
	public string GeneratePDF(string content, string name, string size)
	{
		return $"PDF file: {name} {content} generated. File Size: {size}.";
	}
}
