using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;

        public void SetDriverName(string name) => this.name = name;
        public void PopAWheely()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("YEEEEEEE HAAAAEEWW!");
            }
        }
        /*public Motorcycle()
        {
            // "ctor" and Tab creates a custom default consteructor
        }
        public Motorcycle(int driverIntensity)
        {
            this.driverIntensity = driverIntensity;
        }*/
        // Constructor chaining.
        public Motorcycle() { Console.WriteLine("In default constructor"); }
        public Motorcycle(int intensity)
        : this(intensity, "") { Console.WriteLine("In constructor taking an int"); }
        public Motorcycle(string name)
        : this(0, name) { Console.WriteLine("In constructor taking a string"); }
        // This is the 'master' constructor that does all the real work.
        // Optional args
        public Motorcycle(int intensity = 0, string name = "")
        {
            Console.WriteLine("In main constructor");
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            this.name = name;
        }

    }
}
