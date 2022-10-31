// See https://aka.ms/new-console-template for more information
using StructuralDesignPattern_Adapter;
using StructuralDesignPattern_Adapter.InternalObjects;

Console.WriteLine("Hello, World!");

var excelGenerator = new ExcelFileGenerator();
Console.WriteLine(excelGenerator.GenerateFile("excelFile", "Excel Body", "excelExtension"));
Console.WriteLine();

var wordGenerator = new WordFileGenerator();
Console.WriteLine(wordGenerator.GenerateFile("wordFile", "Word Body", "wordExtension"));
Console.WriteLine();

var pdfGenerator = new PDFGeneratorAdapter();
Console.WriteLine(pdfGenerator.GenerateFile("pdfFile", "PDF Body", ""));
Console.WriteLine();