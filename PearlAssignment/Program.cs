// See https://aka.ms/new-console-template for more information
using PearlAssignment;

var pearl = Pearl.Factory.CreateWithRandomData();

Console.WriteLine(pearl);

INecklace necklace = new Necklace(35);
Console.WriteLine($"We have: {necklace} pearls");