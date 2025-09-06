using static FunWithMethodOverloading.AddOperations;

Console.WriteLine("***** Fun with Method Overloading *****\n");
// Calls int version of Add()
Console.WriteLine(Add(10, 10));
// Calls long version of Add() (using the new digit separator)
Console.WriteLine(Add(900_000_000_000, 900_000_000_000));
// Calls double version of Add()
Console.WriteLine(Add(4.3, 4.4));
Console.ReadLine();
/*static void EnterLogData(string message, string owner = "Programmer")
{
    if (message == null)
    {
        throw new ArgumentNullException(message);
    }
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}*/
static void EnterLogData(string message, string owner = "Programmer")
{
    ArgumentNullException.ThrowIfNull(message);
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}