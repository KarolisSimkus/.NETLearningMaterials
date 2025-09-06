(string FirstLetter, int TheNumber, string SecondLetter) values = ("a", 5, "c");
Console.WriteLine($"First item: {values.FirstLetter}");
Console.WriteLine($"Second item: {values.TheNumber}");
Console.WriteLine($"Third item: {values.SecondLetter}");
//Using the item notation still works!
Console.WriteLine($"First item: {values.Item1}");
Console.WriteLine($"Second item: {values.Item2}");
Console.WriteLine($"Third item: {values.Item3}");
Console.WriteLine("=> Nested Tuples");
var nt = (5, 4, ("a", "b"));
Console.WriteLine("=> Inferred Tuple Names");
var foo = new { Prop1 = "first", Prop2 = "second" };
var bar = (foo.Prop1, foo.Prop2);
Console.WriteLine($"{bar.Prop1};{bar.Prop2}");
Console.WriteLine("=> Tuples Equality/Inequality");
// lifted conversions
var left = (a: 5, b: 10);
(int? a, int? b) nullableMembers = (5, 10);
Console.WriteLine(left == nullableMembers); // Also true
// converted type of left is (long, long)
(long a, long b) longTuple = (5, 10);
Console.WriteLine(left == longTuple); // Also true
// comparisons performed on (long, long) tuples
(long a, int b) longFirst = (5, 10);
(int a, long b) longSecond = (5, 10);
Console.WriteLine(longFirst == longSecond); // Also true
static (int a, string b, bool c) FillTheseValues()
{
    return (9, "Enjoy your string.", true);
}
var samples = FillTheseValues();
Console.WriteLine($"Int is: {samples.a}");
Console.WriteLine($"String is: {samples.b}");
Console.WriteLine($"Boolean is: {samples.c}");

(int X, int Y) myTuple = (4,5);
int x = 0;
int y = 0;
(x, y) = myTuple;
Console.WriteLine($"X is: {x}");
Console.WriteLine($"Y is: {y}");
(int x1, int y1) = myTuple;
Console.WriteLine($"x1 is: {x}");
Console.WriteLine($"y1 is: {y}");