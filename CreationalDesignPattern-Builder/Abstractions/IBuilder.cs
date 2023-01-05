namespace CreationalDesignPattern_Builder.Abstractions;
public interface IBuilder
{
	public void SetEngine();
	public void SetType();
	public void SetModel();
	public void SetVersion();
}
