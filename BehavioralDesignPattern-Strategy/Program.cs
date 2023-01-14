using BehavioralDesignPattern_Strategy;
using BehavioralDesignPattern_Strategy.Client;
using BehavioralDesignPattern_Strategy.Strategies;

Console.WriteLine("Behavioral Design Pattern - Strategy");

var walkStrategy = new WalkStrategy();
var carStrategy = new CarStrategy();
var bikeStrategy = new BikeStrategy();

var walkRoute = new Map(walkStrategy);
var carRoute = new Map(carStrategy);
var bikeRoute = new Map(bikeStrategy);

var coordStart = new Coordinate();
var coordTarget = new Coordinate();

walkRoute.CreateRoute(coordStart, coordTarget);
carRoute.CreateRoute(coordStart, coordTarget);
bikeRoute.CreateRoute(coordStart, coordTarget);