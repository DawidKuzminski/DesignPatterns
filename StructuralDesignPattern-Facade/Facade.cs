using StructuralDesignPattern_Facade.ThirdPatryLib;

namespace StructuralDesignPattern_Facade;
internal class Facade
{
	private readonly AuthService _authService;
	private readonly UserRoleChecker _userRoleChecker;
	private readonly DataService _dataService;

	public Facade(AuthService authService, UserRoleChecker userRoleChecker, DataService dataService)
	{
		_authService = authService;
		_userRoleChecker = userRoleChecker;
		_dataService = dataService;
	}

	public void GetAllData()
	{
		Console.WriteLine(_authService.Login("Daski", "Oklaski"));
		Console.WriteLine(_userRoleChecker.ValidateUserRole("Ultra Instinct Admin"));
		Console.WriteLine(_dataService.GetAllData());
	}
}
