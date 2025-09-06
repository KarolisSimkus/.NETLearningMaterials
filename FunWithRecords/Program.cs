using FunWithRecords;
Console.WriteLine("Fun with Records!");
//Use object initialization
Car myCar = new Car
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My car: ");
DisplayCarStats(myCar);
Console.WriteLine();
//Use the custom constructor
Car anotherMyCar = new Car("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car: ");
DisplayCarStats(anotherMyCar);
Console.WriteLine();
//Compile error if property is changed
//myCar.Color = "Red";
Console.ReadLine();
static void DisplayCarStats(Car c)
{
    Console.WriteLine("Car Make: {0}", c.Make);
    Console.WriteLine("Car Model: {0}", c.Model);
    Console.WriteLine("Car Color: {0}", c.Color);
}

Console.WriteLine("*************** RECORDS *********************");
//Use object initialization
CarRecord myCarRecord = new CarRecord
{
    Make = "Honda",
    Model = "Pilot",
    Color = "Blue"
};
Console.WriteLine("My car: ");
DisplayCarRecordStats(myCarRecord);
Console.WriteLine();
//Use the custom constructor
CarRecord anotherMyCarRecord = new CarRecord("Honda", "Pilot", "Blue");
Console.WriteLine("Another variable for my car: ");
Console.WriteLine(anotherMyCarRecord.ToString());
Console.WriteLine();
//Compile error if property is changed
//myCarRecord.Color = "Red";
Console.ReadLine();
static void DisplayCarRecordStats(CarRecord c)
{
    Console.WriteLine("Car Make: {0}", c.Make);
    Console.WriteLine("Car Model: {0}", c.Model);
    Console.WriteLine("Car Color: {0}", c.Color);
}

// Records that dont work
//CarRecord myCarRecorda = new CarRecord("Honda", "Pilot", "Blue");
//myCarRecorda.Deconstruct(out string a, out string b, out string c);
//Console.WriteLine($"Make: {a} Model: {b} Color: {c}");