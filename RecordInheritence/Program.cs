using RecordInheritence;
Console.WriteLine("Record type inheritance!");
Car c = new Car("Honda", "Pilot", "Blue");
MiniVan m = new MiniVan("Honda", "Pilot", "Blue", 10);
Console.WriteLine($"Checking MiniVan is-a Car:{m is Car}");