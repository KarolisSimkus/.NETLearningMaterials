Console.WriteLine("***** Calling method with unsafe code *****");
unsafe
{
    // Work with pointer types here!
    int myInt = 10;

    SquareIntPointer(&myInt);
    Console.WriteLine("myInt: {0}", myInt);
}
// Can't work with pointers here!
int myInt2 = 5;
// Compiler error! Must be in unsafe context!
//SquareIntPointer(&myInt2);
Console.WriteLine("myInt: {0}", myInt2);

Console.WriteLine("***** Calling method with unsafe code *****");
// Values for swap.
int i = 10, j = 20;
// Swap values "safely."
Console.WriteLine("\n***** Safe swap *****");
Console.WriteLine("Values before safe swap: i = {0}, j = {1}", i, j);
SafeSwap(ref i, ref j);
Console.WriteLine("Values after safe swap: i = {0}, j = {1}", i, j);
// Swap values "unsafely."
Console.WriteLine("\n***** Unsafe swap *****");
Console.WriteLine("Values before unsafe swap: i = {0}, j = {1}", i, j);
unsafe { UnsafeSwap(&i, &j); }
Console.WriteLine("Values after unsafe swap: i = {0}, j = {1}", i, j);
Console.ReadLine();
static unsafe void SquareIntPointer(int* myIntPointer)
{
    // Square the value just for a test.
    *myIntPointer *= *myIntPointer;
}
unsafe static void UnsafeSwap(int* i, int* j)
{
    int temp = *i;
    *i = *j;
    *j = temp;
}
static void SafeSwap(ref int i, ref int j)
{
    int temp = i;
    i = j;
    j = temp;
}