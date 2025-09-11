using CustomEnumerator;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("***** Fun with the Yield Keyword *****\n");
Garage carLot = new Garage();
IEnumerator carEnumerator = carLot.GetEnumerator();
Console.ReadLine();

Console.WriteLine("***** Fun with the Yield Keyword *****\n");
Garage carLot2 = new Garage();
try
{
    //Error at this time
    //var carEnumerator = carLot.GetEnumerator();
}
catch (Exception e)
{
    Console.WriteLine($"Exception occurred on GetEnumerator");
}
Console.ReadLine();

Console.WriteLine("***** Fun with the Yield Keyword *****\n");
Garage carLot3 = new Garage();
// Get items using GetEnumerator().
foreach (Car c in carLot3)
{
    Console.WriteLine("{0} is going {1} MPH",
    c.PetName, c.CurrentSpeed);
}
Console.WriteLine();
// Get items (in reverse!) using named iterator.
foreach (Car c in carLot3.GetTheCars(true))
{
    Console.WriteLine("{0} is going {1} MPH",
    c.PetName, c.CurrentSpeed);
}
Console.ReadLine();