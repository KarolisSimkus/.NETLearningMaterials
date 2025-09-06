using EmployeeApp;
/*
Console.WriteLine("***** Fun with Encapsulation *****\n");
Employee emp = new Employee("Marvin", 456, 30_000);
emp.GiveBonus(1000);
emp.DisplayStats();

 Use the get/set methods to interact with the object's name.
emp.SetName("Marv");
Console.WriteLine("Employee is named: {0}", emp.GetName());
Console.ReadLine();

// Longer than 15 characters! Error will print to console.
Employee emp2 = new Employee();
emp2.SetName("Xena the warrior princess");
Console.ReadLine();
Console.WriteLine("***** Fun with Encapsulation *****\n");
Employee emp1 = new Employee("Marvin", 456, 30000);
emp1.GiveBonus(1000);
emp1.DisplayStats();
// Reset and then get the Name property.
emp1.Name = "Marv";
Console.WriteLine("Employee is named: {0}", emp1.Name);
Console.ReadLine();
*/
Employee joe = new Employee();
// If Only using get and set methods:
// joe.SetAge(joe.GetAge() + 1);
joe.Age++;

Employee emp = new Employee("Marvin", 45, 123, 1000, "111-11-1111", EmployeePayTypeEnum.
Salaried);
Console.WriteLine(emp.Pay);
emp.GiveBonus(100);
Console.WriteLine(emp.Pay);