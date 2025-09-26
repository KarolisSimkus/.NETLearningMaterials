using CarEvents;
using PublicDelegateProblem;

/*Console.WriteLine("***** Fun with Events *****\n");
Car c1 = new Car("SlugBug", 100, 10);
// Register event handlers.
c1.AboutToBlow += CarIsAlmostDoomed;
c1.AboutToBlow += CarAboutToBlow;
Car.CarEngineHandler d = CarExploded;
c1.Exploded += d;
Console.WriteLine("***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}
// Remove CarExploded method
// from invocation list.
c1.Exploded -= d;
Console.WriteLine("\n***** Speeding up *****");
for (int i = 0; i < 6; i++)
{
    c1.Accelerate(20);
}
Console.ReadLine();*/
/*static void CarAboutToBlow(string msg)
{
    Console.WriteLine(msg);
}*/
Console.WriteLine("***** Prim and Proper Events *****\n");
// Make a car as usual.
Car c1 = new Car("SlugBug", 100, 10);
// Register event handlers.
c1.AboutToBlow += CarIsAlmostDoomed;
c1.AboutToBlow += CarAboutToBlow;
EventHandler<CarEventArgs> d = CarExploded;
c1.Exploded += d;
static void CarIsAlmostDoomed(string msg)
{
    Console.WriteLine("=> Critical Message from Car: {0}", msg);
}
static void CarExploded(string msg)
{
    Console.WriteLine(msg);
}
static void CarAboutToBlow(object sender, CarEventArgs e)
{
    // Just to be safe, perform a
    // runtime check before casting.
    if (sender is Car c)
    {
        Console.WriteLine(
        $"Critical Message from {c.PetName}: {e.msg}");
    }
}