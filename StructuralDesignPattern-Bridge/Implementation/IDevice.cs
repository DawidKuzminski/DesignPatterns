namespace StructuralDesignPattern_Bridge.Implementation;
internal interface IDevice
{
	public int Volume { get; set; }
	public int Channel { get; set; }
	public bool IsEnabled { get; set; }
}
