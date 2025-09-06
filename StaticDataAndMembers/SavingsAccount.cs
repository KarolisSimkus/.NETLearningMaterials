using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        public double currBalance;
        // A static point of data.
        public static double currInterestRate;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
        //Static
        public static void SetInterestRate(double interestRate) { 
            currInterestRate = interestRate;
        }
        public static double GetInterestRate() => currInterestRate;
        // A static constructor!
        static SavingsAccount()
        {
            Console.WriteLine("In static constructor!");
            currInterestRate = 0.04;
        }
    }
}
