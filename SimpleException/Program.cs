using SimpleException;
using System.Collections;

Console.WriteLine("***** Simple Exception Example *****");
Console.WriteLine("=> Creating a car and stepping on it!");
Car myCar = new Car("Zippy", 20);
myCar.CrankTunes(true);
try
{
    for (int i = 0; i < 10; i++)
    {
        myCar.Accelerate(10);
    }
}
catch (Exception ex) {
    // Handle the thrown exception.
    Console.WriteLine("\n*** Error! ***");
    Console.WriteLine("Method: {0}", ex.TargetSite);
    Console.WriteLine("Member name: {0}", ex.TargetSite);
    Console.WriteLine("Class defining member: {0}", ex.TargetSite.DeclaringType);
    Console.WriteLine("Member type: {0}", ex.TargetSite.MemberType);
    Console.WriteLine("Message: {0}", ex.Message);
    Console.WriteLine("Source: {0}", ex.Source);
    Console.WriteLine("Stack: {0}", ex.StackTrace);
    Console.WriteLine("Help Link: {0}", ex.HelpLink);
    Console.WriteLine("\n-> Custom Data:");
    foreach (DictionaryEntry de in ex.Data)
    {
        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
    }
}
Console.ReadLine();
Console.WriteLine("\n***** Out of exception logic *****");
Console.ReadLine();