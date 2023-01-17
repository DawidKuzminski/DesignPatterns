using BehavioralDesignPattern_TemplateMethod;

Console.WriteLine("Behavioral Design Pattern - Template Method");

var excelGenerator = new ExcelGenerator();
excelGenerator.GenerateReport();
Console.WriteLine("---------------------------------------------------");
var csvGenerator = new CSVGenerator();
csvGenerator.GenerateReport();
Console.WriteLine("---------------------------------------------------");
var pdfGenerator = new PDFGenerator();
pdfGenerator.GenerateReport();
