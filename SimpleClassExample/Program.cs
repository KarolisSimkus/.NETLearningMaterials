// See https://aka.ms/new-console-template for more information
using SimpleClassExample;
Console.WriteLine("***** Fun with Class Types *****\n");
// Allocate and configure a Car object.
// Must use new keyword!!!
Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;
// Speed up the car a few times and print out the
// new state.
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}
Console.ReadLine();

Car car = new Car();
car.PrintState();

Console.ReadLine();

Car car1 = new Car("Mary");
car1.PrintState();

Console.ReadLine();

Car car2 = new Car("Daisy", 75);
car2.PrintState();

Console.WriteLine("***** Fun with Class Types *****\n");
Motorcycle mc = new Motorcycle();
mc.PopAWheely();
Console.ReadLine();

// Make a Motorcycle with a rider named Tiny?
// Make a Motorcycle.
Motorcycle c = new Motorcycle(5);
c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine("Rider name is {0}", c.name);
Console.ReadLine();
static void MakeSomeBikes()
{
    // driverName = "", driverIntensity = 0
    Motorcycle m1 = new Motorcycle();
    Console.WriteLine("Name= {0}, Intensity= {1}",
    m1.name, m1.driverIntensity);
    // driverName = "Tiny", driverIntensity = 0
    Motorcycle m2 = new Motorcycle(name: "Tiny");
    Console.WriteLine("Name= {0}, Intensity= {1}",
    m2.name, m2.driverIntensity);
    // driverName = "", driverIntensity = 7
    Motorcycle m3 = new Motorcycle(7);
    Console.WriteLine("Name= {0}, Intensity= {1}",
    m3.name, m3.driverIntensity);
}

// Compiler error! WriteLine() is not an object level method!
/*Console c = new Console();
c.WriteLine("I can't be printed...");*/
// Instead, simply prefix the class name to the static WriteLine() member.
// Correct! WriteLine() is a static method.
Console.WriteLine("Much better! Thanks...");
Console.ReadLine();
MakeSomeBikes();