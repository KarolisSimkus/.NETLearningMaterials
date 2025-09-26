using ExtensionMethods;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("***** Fun with Extension Methods *****\n");

int myInt = 12345678;
myInt.DisplayDefiningAssembly();

System.Data.DataSet d =  new System.Data.DataSet();
d.DisplayDefiningAssembly();

// Use new integer functionality.
Console.WriteLine("Value of myInt: {0}", myInt);
Console.WriteLine("Reversed digits of myInt: {0}",
myInt.ReverseDigits());
Console.ReadLine();