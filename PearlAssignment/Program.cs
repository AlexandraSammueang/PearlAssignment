// See https://aka.ms/new-console-template for more information
using PearlAssignment;

var pearl = Pearl.Factory.CreateWithRandomData();

Console.WriteLine(pearl);

INecklace necklace = Necklace.Factory.CreateWithRandomData(35);
Console.WriteLine($"We have: {necklace} pearls");