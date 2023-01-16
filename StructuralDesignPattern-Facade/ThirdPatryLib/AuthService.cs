namespace StructuralDesignPattern_Facade.ThirdPatryLib;
internal class AuthService
{
	public string Login(string userName, string password)
	{
		return $"User {userName} logged";
	}
}
