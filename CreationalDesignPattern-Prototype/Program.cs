// See https://aka.ms/new-console-template for more information
using CreationalDesignPattern_Prototype;

Console.WriteLine("Creational design pattern - Prototype");

Console.WriteLine("Prototype - Shallow Copy");
var circle = new Circle
{
	X = 11,
	Y = 11,
	Radius = 11,
	Border = new Border 
	{
		Color = "Black",
		Size = "4px"
	}
};

var shallowCopyCircle = circle.ShallowClone();

var shallowCopyReferenceEquals = ReferenceEquals(circle, shallowCopyCircle);
Console.WriteLine($"Shallow Copy Circle Ref Equals: {shallowCopyReferenceEquals}");

var shallowCopyCircleBorderReferenceEquals = ReferenceEquals(circle.Border, shallowCopyCircle.Border);
Console.WriteLine($"Shallow Copy Circle Border Ref Equals: {shallowCopyCircleBorderReferenceEquals}");

Console.WriteLine($"Circle Border Color: {circle.Border.Color}");
Console.WriteLine($"Shallow Copy Circle Border Color: {shallowCopyCircle.Border.Color}");

shallowCopyCircle.Border.Color = "Red";
Console.WriteLine($"Circle Border Color: {circle.Border.Color}");
Console.WriteLine($"Shallow Copy Circle Border Color: {shallowCopyCircle.Border.Color}");

Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Prototype - Deep Copy");
var deepCopyCircle = circle.DeepClone();
var deepCopyReferenceEquals = ReferenceEquals(circle, deepCopyCircle);
Console.WriteLine($"Deep Copy Circle Ref Equals: {deepCopyReferenceEquals}");

var deepCopyCircleBorderReferenceEquals = ReferenceEquals(circle.Border, deepCopyCircle.Border);
Console.WriteLine($"Deep Copy Circle Border Ref Equals: {deepCopyCircleBorderReferenceEquals}");

Console.WriteLine("-------------------------------------------------------------------");
Console.WriteLine("Prototype - Deep Copy - by Serialize and deserialize JSON");
var deepCopyCircleByJson = circle.DeepClone();
var deepCopyByJsonReferenceEquals = ReferenceEquals(circle, deepCopyCircleByJson);
Console.WriteLine($"Deep Copy Circle Ref Equals: {deepCopyByJsonReferenceEquals}");

var deepCopyCircleBorderByJsonReferenceEquals = ReferenceEquals(circle.Border, deepCopyCircleByJson.Border);
Console.WriteLine($"Deep Copy Circle Border Ref Equals: {deepCopyCircleBorderByJsonReferenceEquals}");

deepCopyCircle.Border.Color = "Blue";
deepCopyCircleByJson.Border.Color = "Green";

Console.WriteLine($"Circle Border Color: {circle.Border.Color}");
Console.WriteLine($"Deep Copy Circle Border By Color: {deepCopyCircle.Border.Color}");
Console.WriteLine($"Deep Copy Circle Border By Json Color: {deepCopyCircleByJson.Border.Color}");

Console.ReadLine();

