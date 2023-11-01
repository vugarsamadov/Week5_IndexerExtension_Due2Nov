using Week5_IndexerExtension_Due2Nov.Extensions;
using Week5_IndexerExtension_Due2Nov.Models;

// Extensions

Console.WriteLine(5.IsPrime());
Console.WriteLine(3301.IsPrime());
Console.WriteLine(6.IsPrime());
Console.WriteLine();
Console.WriteLine(6.IsPowOfTwo());
Console.WriteLine(16.IsPowOfTwo());
Console.WriteLine(5.IsPowOfTwo());
Console.WriteLine(2.IsPowOfTwo());
Console.WriteLine(9.IsPowOfTwo());
Console.WriteLine();
// Indexer

Car car1 = new Car()
{
    Name = "Mitsubishi"
};
Car car2 = new Car()
{
    Name = "BMW"
};



Gallery gallery = new();
gallery.Cars = new Car[] { car1, car2 };

Console.WriteLine(gallery[3]);
Console.WriteLine(gallery[0].Name);
Console.WriteLine(gallery["BMW"]);
Console.WriteLine(gallery["Jeep"]);








