using CarEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PublicDelegateProblem
{
    public class Car
    {
        //public delegate void CarEngineHandler(string msgForCaller);
        // Now a public member!
        public CarEngineHandler ListOfHandlers;
        private bool _carIsDead;

        public int CurrentSpeed { get;  set; }
        public int MaxSpeed { get;  set; }
        public string PetName { get;  set; }

        public Car() { }
        public Car(string carName, int max, int curr)
        {
            PetName = carName;
            CurrentSpeed = curr;
            MaxSpeed = max;
        }

        // Just fire out the Exploded notification.
        /*public void Accelerate(int delta)
        {
            if (ListOfHandlers != null)
            {
                ListOfHandlers("Sorry, this car is dead...");
            }
        }*/
        // This delegate works in conjunction with the
        // Car's events.
        public delegate void CarEngineHandler(object sender, CarEventArgs e);
        // This car can send these events.
        /*public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;*/
        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;

        public void Accelerate(int delta)
        {
            // If the car is dead, fire Exploded event.
            if (_carIsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;
                // Almost dead?
                if (10 == MaxSpeed - CurrentSpeed)
                {
                    AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));
                }
                // Still OK!
                if (CurrentSpeed >= MaxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }
    }
}
