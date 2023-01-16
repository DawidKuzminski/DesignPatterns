using StructuralDesignPattern_Facade;
using StructuralDesignPattern_Facade.ThirdPatryLib;

Console.WriteLine("Structural Design Pattern - Facade");

var facade = new Facade(new AuthService(), new UserRoleChecker(), new DataService());
facade.GetAllData();
