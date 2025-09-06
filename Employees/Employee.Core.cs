using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        // Field Data
        protected string _empName;
        protected int _empId;
        protected float _currPay;
        protected int _empAge;
        protected string _empSSN;
        protected EmployeePayTypeEnum _payType;

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
