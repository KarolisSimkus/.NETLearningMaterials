using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDispose
{
    internal class MyResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("In Dispose");
        }
        private static void UsingDeclaration()
        {
            //This variable will be in scope until the end of the method
            using var rw = new MyResourceWrapper();
            //Do something here
            Console.WriteLine("About to dispose.");
            //Variable is disposed at this point.
        }
    }
}
