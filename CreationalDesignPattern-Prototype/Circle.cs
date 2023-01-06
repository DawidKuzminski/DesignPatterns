using Newtonsoft.Json;

namespace CreationalDesignPattern_Prototype;
internal class Circle
{
	public int X { get; set; }
	public int Y { get; set; }
	public int Radius { get; set; }
	public Border Border { get; set; }

	public Circle ShallowClone()
	{
		return (Circle)this.MemberwiseClone();
	}

	public Circle DeepClone()
	{
		var clone = (Circle)this.MemberwiseClone();
		clone.Border = new Border
		{
			Color = Border.Color,
			Size = Border.Size
		};

		return clone;
	}

	public Circle DeepCloneWitJSON()
	{
		var cloneAsJson = JsonConvert.SerializeObject(this);
		return JsonConvert.DeserializeObject<Circle>(cloneAsJson);
	}
}
