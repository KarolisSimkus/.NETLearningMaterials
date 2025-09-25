Console.WriteLine("***** Fun with Conversions *****\n");
// Make a Rectangle.
Rectangle r = new Rectangle(15, 4);
Console.WriteLine(r.ToString());
r.Draw();
Console.WriteLine();
// Convert r into a Square,
// based on the height of the Rectangle.
Square s = (Square)r;
Console.WriteLine(s.ToString());
s.Draw();
Console.ReadLine();

// Implicit cast OK!
Square s3 = new Square { Length = 7 };
Rectangle rect2 = s3;
Console.WriteLine("rect2 = {0}", rect2);
// Explicit cast syntax still OK!
Square s4 = new Square { Length = 3 };
Rectangle rect3 = (Rectangle)s4;
Console.WriteLine("rect3 = {0}", rect3);
Console.ReadLine();


public struct Rectangle
{
    public int Width {  get; set; }
    public int Height { get; set; }

    public Rectangle(int w, int h)
    {
        Width = w; Height = h;
    }
    public void Draw()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Width; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public override string ToString()
        => $"[Width = {Width}; Height = {Height}]";

    public static implicit operator Rectangle(Square square)
    {
        Rectangle r = new Rectangle
        {
            Height = square.Length,
            Width = square.Length * 2
        };
        return r;
    }
}

public struct Square
{
    public int Length {  get; set; }

    public Square(int l)
    {
        Length = l;
    }
    public void Draw()
    {
        for (int i = 0; i < Length; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public override string ToString() => $"[Length = {Length}]";

    // Rectangles can be explicitly converted into Squares.
    public static explicit operator Square(Rectangle r)
    {
        Square s = new Square { Length = r.Height };
        return s;
    }

    public static explicit operator Square(int sideLength)
    {
        Square newSq = new Square { Length = sideLength };
        return newSq;
    }
    public static explicit operator int(Square s) => s.Length;
}

