namespace StructuralDesignPattern_Facade.ThirdPatryLib;
internal class UserRoleChecker
{
	public string ValidateUserRole(string userRole)
	{
		return $"User with role: {userRole} have access to data service";
	}
}
