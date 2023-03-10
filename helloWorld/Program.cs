using Humanizer;


// See https://aka.ms/new-console-template for more information
Console.Write("Insert your name, please: ");
var name = Console.ReadLine();
Console.WriteLine($"Hello, {name.Pascalize()}!");
