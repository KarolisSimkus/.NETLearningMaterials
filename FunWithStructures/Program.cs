

Console.WriteLine("***** A First Look at Structures *****\n");
// Create an initial Point.
//Point myPoint;
//myPoint.X = 349;
//myPoint.Y = 76;
//myPoint.Display();
// Adjust the X and Y values.
//myPoint.Increment();
//myPoint.Display();
//Console.ReadLine();

// Error! Did not assign Y value.
//Point p1;
//p1.X = 10;
//p1.Y = 10;
//p1.Display();
// OK! Both fields assigned before use.
//Point p2;
//p2.X = 10;
//p2.Y = 10;
//p2.Display();

// Set all fields to default values
// using the default constructor.
//Point p1 = new Point();
// Prints X=0,Y=0.
//p1.Display();

// Call custom constructor.
//Point p2 = new Point(50, 60);
// Prints X=50,Y=60.
//p2.Display();

PointWithReadOnly p3 =
new PointWithReadOnly(50, 60, "Point w/RO");
p3.Display();

var s = new DisposableRefStruct(50, 60);
s.Display();
s.Dispose();

struct Point
{
    // Fields of the structure.
    public int X = 5;
    public int Y = 7;
    // Add 1 to the (X, Y) position.
    // A custom constructor.
    //Parameterless constructor
    public Point()
    {
    }
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
    public void Increment()
    {
        X++; Y++;
    }
    // Subtract 1 from the (X, Y) position.
    public void Decrement()
    {
        X--; Y--;
    }
    // Display the current position.
    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}
readonly struct ReadOnlyPoint
{
    // Fields of the structure.
    public int X { get; }
    public int Y { get; }
    // Display the current position and name.
    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
    public ReadOnlyPoint(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
}
ref struct DisposableRefStruct
{
    public int X;
    public readonly int Y;
    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }
    // A custom constructor.
    public DisposableRefStruct(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
        Console.WriteLine("Created!");
    }
    public void Dispose()
    {
        //clean up any resources here
        Console.WriteLine("Disposed!");
    }
}