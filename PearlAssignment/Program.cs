// See https://aka.ms/new-console-template for more information
using PearlAssignment;

using Type = PearlAssignment.Type;

var pearl = Pearl.Factory.CreateWithRandomData();

Console.WriteLine(pearl);

Necklace necklace = Necklace.Factory.CreateWithRandomData(35);
Console.WriteLine($"Our necklace contains 35 different pearls: \n{necklace}");

Console.WriteLine($"Nr of pearls: {necklace.Count()}");
Console.WriteLine($"Nr of Freshwater pearls: {necklace.Count(Type.FreshWater)}");
Console.WriteLine($"Nr of Saltwater pearls: {necklace.Count(Type.SaltWater)}");
Console.WriteLine($"Price of the necklace: {necklace.GetPrice()} SEK");


////Sort the Necklace
Console.WriteLine("\nSort the pearls in the Necklace ");
necklace.Sort();
Console.WriteLine(necklace);
//Find a pearl, test by using a kown pearl
Console.WriteLine("\nCheck if the pearl exists!");

try

{
    var findnecklace = necklace[89];
    var idx = necklace.IndexOf(findnecklace);
    if (!(idx == -1 || idx > 35))
    {
        Console.WriteLine($"This necklace is in position {idx}");
    }




}
catch { Console.WriteLine("This index does not exist"); }

