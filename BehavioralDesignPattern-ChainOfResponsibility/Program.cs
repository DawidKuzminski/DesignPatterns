// See https://aka.ms/new-console-template for more information
using BehavioralDesignPattern_ChainOfResponsibility;
using BehavioralDesignPattern_ChainOfResponsibility.Communication;
using BehavioralDesignPattern_ChainOfResponsibility.Handlers;

Console.WriteLine("Behavioral Design Pattern - Chain of Responsibility");

var requestNotAuth = new RequestContext
{ 
	Request = new Request 
	{
		EntityId = 101,
		UserId = 13,
		UserRole = "User"
	},
	Response = new Response()
};

var resultHandler = new ResultHandler(null);
var validationHandler = new ValidationHendler(resultHandler);
var authorizationHandler = new AuthorizationHandler(validationHandler);

authorizationHandler.Handle(requestNotAuth);

Console.WriteLine($"IsSucessful: {requestNotAuth.Response.IsSuccess}");
Console.WriteLine($"Message: {requestNotAuth.Response.Message}");
Console.WriteLine($"Data: {requestNotAuth.Response.Data}");

Console.WriteLine("-----------------------------------------------");
var requestNotValid = new RequestContext
{
	Request = new Request
	{
		EntityId = 99,
		UserId = 13,
		UserRole = "Admin"
	},
	Response = new Response()
};

var resultHandler2 = new ResultHandler(null);
var validationHandler2 = new ValidationHendler(resultHandler2);
var authorizationHandler2 = new AuthorizationHandler(validationHandler2);

authorizationHandler2.Handle(requestNotValid);

Console.WriteLine($"IsSucessful: {requestNotValid.Response.IsSuccess}");
Console.WriteLine($"Message: {requestNotValid.Response.Message}");
Console.WriteLine($"Data: {requestNotValid.Response.Data}");

Console.WriteLine("-----------------------------------------------");
var requestValid = new RequestContext
{
	Request = new Request
	{
		EntityId = 101,
		UserId = 14,
		UserRole = "Admin"
	},
	Response = new Response()
};

var resultHandler3 = new ResultHandler(null);
var validationHandler3 = new ValidationHendler(resultHandler3);
var authorizationHandler3 = new AuthorizationHandler(validationHandler3);

authorizationHandler3.Handle(requestValid);

Console.WriteLine($"IsSucessful: {requestValid.Response.IsSuccess}");
Console.WriteLine($"Message: {requestValid.Response.Message}");
Console.WriteLine($"Data: {requestValid.Response.Data}");