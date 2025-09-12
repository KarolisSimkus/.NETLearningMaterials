using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFinalize
{
    internal class MyResourceWrapper
    {
        // Compile-time error!
        // protected override void Finalize() { }
        // Clean up unmanaged resources here.
        // Beep when destroyed (testing purposes only!)
        ~MyResourceWrapper() => Console.Beep();
    }
}
