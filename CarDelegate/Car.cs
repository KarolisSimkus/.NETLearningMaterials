using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }
        // Is the car alive or dead?
        private bool _carIsDead;
        public Car() { }
        public Car(string name,int maxSpeed, int currentSpeed) 
        {
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
            PetName = name;
        }
        // 1) Define a delegate type.
        public delegate void CarEngineHandler(string msgForCaller);
        // 2) Define a member variable of this delegate.
        private CarEngineHandler _listOfHandlers;
        // 3) Add registration function for the caller.
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers += methodToCall;
        }
        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers -= methodToCall;
        }

        public void Accelerate(int delta)
        {
            // If this car is "dead," send dead message.
            if (_carIsDead)
            {
                _listOfHandlers?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;
                // Is this car "almost dead"?
                if (10 == (MaxSpeed - CurrentSpeed))
                {
                    _listOfHandlers?.Invoke("Careful buddy! Gonna blow!");
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
