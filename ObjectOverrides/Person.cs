using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }

        public string SSN { get; } = "";
        public Person(string fName, string lName, int personAge, string ssn)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
            SSN = ssn;
        }
        // Return a hash code based on unique string data.
        public override int GetHashCode() => SSN.GetHashCode();
        public override string ToString() 
            => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";
        /*public override bool Equals(object obj)
        {
            if (!(obj is Person temp))
            {
                return false;
            }
            if (temp.FirstName == this.FirstName
            && temp.LastName == this.LastName
            && temp.Age == this.Age)
            {
                return true;
            }
            return false;
        }*/
        public override bool Equals(object obj)
            => obj?.ToString() == ToString();
    }
}
