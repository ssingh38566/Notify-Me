// See https://aka.ms/new-console-template for more information
using NotifyMe.Components;

Console.WriteLine("Hello, World!");

Beverage beverage = new Coffee();
Console.WriteLine(beverage.GetDesc());


beverage = new CaramelDecorator(beverage);

Console.WriteLine(beverage.GetDesc());

Console.ReadLine();
