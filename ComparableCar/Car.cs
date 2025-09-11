using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    internal class Car : IComparable
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        public int CarID { get; set; }

        private bool _carIsDead;

        private readonly Radio _radio = new Radio();

        public Car() { }
        public Car(string name, int speed, int id)
        {
            CurrentSpeed = speed;
            PetName = name;
            CarID = id;
        }
        public void CrankTunes(bool state)
        {
            _radio.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed >= MaxSpeed)
                {
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    // Use the "throw" keyword to raise an exception.
                    throw new Exception($"{PetName} has overheated!")
                    {
                        HelpLink = "https://www.cars.com",
                        Data = {
                            {"TimeStamp",$"The car exploded at {DateTime.Now}"},
                            {"Cause","You have a lead foot."}
                        }
                    };
                }
                Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
            }
        }

        // IComparable implementation.
        int IComparable.CompareTo(object obj)
        {
            if (obj is Car temp)
            {
                if (this.CarID > temp.CarID)
                {
                    return 1;
                }
                if (this.CarID < temp.CarID)
                {
                    return -1;
                }
                return 0;
            }
            /* OR
             if (obj is Car temp)
            {
                return this.CarID.CompareTo(temp.CarID);
            }
            */
            throw new ArgumentException("Parameter is not a Car!");
        }
        // Property to return the PetNameComparer.
        public static IComparer SortByPetName
        => (IComparer)new PetNameComparer();
    }
}
