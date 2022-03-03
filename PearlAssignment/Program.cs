// See https://aka.ms/new-console-template for more information
using PearlAssignment;

//var pearl = Pearl.Factory.CreateWithRandomData();

//Console.WriteLine(pearl);

INecklace necklace = Necklace.Factory.CreateWithRandomData(35);
Console.WriteLine($"Our necklace contains 35 different pearls: \n{necklace}");

//Necklace _necklace = new Necklace();
//Find a pearl, test by using a kown pearl
//Console.WriteLine("\nFind a pearl, test by using a known pearl");
//var findPearl = Necklace._necklace[10];

//Console.WriteLine($"Looking for Pearl:\n{findPearl}");
//int idx = _necklace.IndexOf(findPearl);
