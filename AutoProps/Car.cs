using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    internal class Car
    {
        // Automatic properties! No need to define backing fields.
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public int MyProperty { get; set; }
        // Read-only property? This is OK!
        public int MyReadOnlyProp { get; }
        // Write only property? Error!
        // public int MyWriteOnlyProp { set; }
        public void DisplayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}
