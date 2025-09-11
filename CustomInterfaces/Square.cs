using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class Square : Shape, IRegularPointy
    {
        public Square() { }
        public Square(string name) : base(name) { }
        //Draw comes from the Shape base class
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
        //This comes from the IPointy interface
        public byte Points => 4;
        public int SideLength { get; set; }
        public int NumberOfSides { get; set; }
    }
}
