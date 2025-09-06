using AutoProps;

Console.WriteLine("***** Fun with Automatic Properties *****\n");
Car c = new Car();
c.PetName = "Frank";
c.Speed = 55;
c.Color = "Red";
c.DisplayStats();
Console.ReadLine();

/*Garage g = new Garage();
// OK, prints default value of zero.
Console.WriteLine("Number of Cars: {0}", g.NumberOfCars);
// Runtime error! Backing field is currently null!
//Console.WriteLine(g.MyAuto.PetName);
Console.ReadLine();*/

// Put car in the garage.
Garage g = new Garage();
g.MyAuto = c;
Console.WriteLine("Number of Cars in garage: {0}", g.NumberOfCars);
Console.WriteLine("Your car is named: {0}", g.MyAuto.PetName);
Console.ReadLine();