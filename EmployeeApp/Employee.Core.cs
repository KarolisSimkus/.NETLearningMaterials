using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        // Field Data
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;
        private string _empSSN;

        // Read only SSN
        //public string SocialSecurityNumber => _empSSN;
        public string SocialSecurityNumber
        {
            get => _empSSN;
            private set => _empSSN = value;
        }
        public int Age
        { get { return _empAge; } set { _empAge = value; } }

        private DateTime _hireDate;
        public DateTime HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }
    }
}
