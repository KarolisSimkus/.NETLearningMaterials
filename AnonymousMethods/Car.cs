using AnonymousMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    public class Car
    {
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

        public delegate void CarEngineHandler(object sender, CarEventArgs e);
        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;

        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;
                if (10 == MaxSpeed - CurrentSpeed)
                {
                    AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!"));
                }
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
