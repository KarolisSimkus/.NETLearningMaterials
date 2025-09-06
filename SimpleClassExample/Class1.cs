using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        public string petName;
        public int currSpeed;

        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        // Here, currSpeed will receive the
        // default value of an int (zero).
        public Car(string pn) => petName = pn;

        // Let caller set the full state of the Car.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
        public Car(string pn, int cs, out bool inDanger)
        {
            petName = pn;
            currSpeed = cs;
            if (cs > 100)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }
        public void PrintState()
            => Console.WriteLine("{0} is going {1} KM/H", petName, currSpeed);

        public void SpeedUp(int delta)
            => currSpeed += delta;
    }
}
