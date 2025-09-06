using BasicInheritance;
using System;

Console.WriteLine("***** Basic Inheritance *****\n");
// Make a Car object, set max speed and current speed.
Car myCar = new Car(80) { Speed = 50 };
// Print current speed.
Console.WriteLine("My car is going {0} MPH", myCar.Speed);
Console.ReadLine();

Console.WriteLine("***** Basic Inheritance *****\n");
// Now make a MiniVan object.
Minivan myVan = new Minivan { Speed = 10 };
Console.WriteLine("My van is going {0} MPH", myVan.Speed);
Console.ReadLine();