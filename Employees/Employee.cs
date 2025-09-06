using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        // Contain a BenefitPackage object
        protected BenefitPackage Package = new BenefitPackage();

        // Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        => Package.ComputePayDeduction();
        // Expose object through a custom property.
        public BenefitPackage Benefits
        {
            get { return Package; }
            set { Package = value; }
        }

        // Enum
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }
        // Methods
        public virtual void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { Age: >= 18, PayType: EmployeePayTypeEnum.Commission, HireDate.Year: > 2020 }
                => Pay += .10F * amount,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly, HireDate: { Year: > 2020 } }
                => Pay += 40F * amount / 2080F,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried, HireDate: { Year: > 2020 } }
                => Pay += amount,
                _ => Pay += 0
            };
        }

        // Updated constructors.
        public Employee() { }
        public Employee(string name, int id, float pay, string ssn)
        : this(name, 0, id, pay, ssn, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int age, int id, float pay, string ssn, EmployeePayTypeEnum payType)
        {
            // Better! Use properties when setting class data.
            // This reduces the amount of duplicate error checks.
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = ssn;
            PayType = payType;
        }
        // Updated DisplayStats() method now accounts for age.
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }
        // Properties!
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        // We could add additional business rules to the sets of these properties;
        // however, there is no need to do so for this example.
        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }
    }
}
