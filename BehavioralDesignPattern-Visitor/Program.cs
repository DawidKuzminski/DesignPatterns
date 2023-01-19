// See https://aka.ms/new-console-template for more information
using BehavioralDesignPattern_Visitor.Abstractions;
using BehavioralDesignPattern_Visitor.Components;
using BehavioralDesignPattern_Visitor.Visitors;
using System.Runtime.CompilerServices;

Console.WriteLine("Behavioral Design Pattern - Visitor");


var cityPolicyComponent = new CityPolicyComponent();
var industryPolicyComponent = new IndustryPolicyComponent();
var visitor = new PolicyVisitor();

cityPolicyComponent.Accept(visitor);
industryPolicyComponent.Accept(visitor);


