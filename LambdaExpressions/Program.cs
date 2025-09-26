using LambdaExpressions;
using System;
using System.Linq.Expressions;

Console.WriteLine("***** Fun with Lambdas *****\n");
TraditionalDelegateSyntax();
AnonymousMethodSyntax();
Console.WriteLine();
LambdaExpressionSyntax();
Console.ReadLine();
// Register with delegate as a lambda expression.
SimpleMath m = new SimpleMath();
m.SetMathHandler((msg, result) =>
{ Console.WriteLine("Message: {0}, Result: {1}", msg, result); });
// This will execute the lambda expression.
m.Add(10, 10);
Console.ReadLine();
// Prints "Enjoy your string!" to the console.
VerySimpleDelegate d = new VerySimpleDelegate(() => { return "Enjoy your string!"; });
Console.WriteLine(d());
VerySimpleDelegate d2 =
new VerySimpleDelegate(() => "Enjoy your string!");
VerySimpleDelegate d3 = () => "Enjoy your string!";

var outerVariable = 0;
Func<int, int, bool> DoWork = (x, y) =>
{
    // if DoWork = static (x,y)...
    // Compile error since its accesing an outer variable
    outerVariable++;
    return true;
};
DoWork(3, 4);
DoWork(_, _);
Console.WriteLine("Outer variable now = {0}", outerVariable);
static void TraditionalDelegateSyntax()
{
    // Make a list of integers.
    List<int> list = new List<int>();
    list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
    // Call FindAll() using traditional delegate syntax.
    Predicate<int> callback = IsEvenNumber;
    List<int> evenNumbers = list.FindAll(callback);
    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
    Console.WriteLine();
}
// Target for the Predicate<> delegate.
static bool IsEvenNumber(int i)
{
    // Is it an even number?
    return (i % 2) == 0;
}
static void AnonymousMethodSyntax()
{
    // Make a list of integers.
    List<int> list = new List<int>();
    list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
    // Now, use an anonymous method.
    List<int> evenNumbers =
    list.FindAll(delegate (int i) { return (i % 2) == 0; });
    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
    Console.WriteLine();
}
static void LambdaExpressionSyntax()
{
    // Make a list of integers.
    List<int> list = new List<int>();
    list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
    // Now process each argument within a group of
    // code statements.
    List<int> evenNumbers = list.FindAll((i) =>
    {
        Console.WriteLine("value of i is currently: {0}", i);
        bool isEven = ((i % 2) == 0);
        return isEven;
    });
    Console.WriteLine("Here are your even numbers:");
    foreach (int evenNumber in evenNumbers)
    {
        Console.Write("{0}\t", evenNumber);
    }
    Console.WriteLine();
}
public delegate string VerySimpleDelegate();